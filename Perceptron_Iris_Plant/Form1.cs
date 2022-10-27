using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Perceptron_Iris_Plant
{
    public partial class Form1 : Form
    {
        string line;
        int entrada = 5; double umbral; char _clase;
        public Form1()
        {
            InitializeComponent();
            printData();
            
        }
        private void printData()
        {
            StreamReader sr = new StreamReader("iris.txt");

            line = sr.ReadLine();

            while (line != null)
            {
                lbdatos.Items.Add(line);
                line = sr.ReadLine();
            }
            sr.Close();
        }
        public void createTable()
        {
            string column_name;
            //se anaden las columnas con sus respectivos nombres
            dgverdad.Columns.Add("index", " ");
            for (int i = 4; i > 0; i--)
            {
                column_name = "X".Insert(1, i.ToString());
                dgverdad.Columns.Add("entrada".Insert(7, i.ToString()), column_name);
            }
            dgverdad.Columns.Add("yesp", "Yesp");
            dgverdad.Columns.Add("ycalc", "Ycalc");

            for (int i = 0; i < 99; i++)
                dgverdad.Rows.Add();
        }
        public void fillCells(double[] doubles, int row)
        {
            int i = 1;

            foreach (double values in doubles)
            {
                dgverdad.Rows[row].Cells[0].Value = row + 1;
                dgverdad.Rows[row].Cells[i].Value = values;
                i++;
            }

            dgverdad.Rows[row].Cells[entrada].Value = row + 1 <= 50 ? -1 : 1;
        }
        public double[] getDoubles(string[] cadena)
        {
            double[] doubles = new double[cadena.Length - 1];
            int i = 0;

            foreach (string num in cadena)
            {
                if (!num.Contains("I"))
                    doubles[i] = Convert.ToDouble(num);
                i++;
            }

            return doubles;
        }
        public void fillTable(int comb)
        {
            int aux = 0;
            string[] division;

            if (comb == 1)
            {
                StreamReader sr = new StreamReader("iris.txt");
                line = sr.ReadLine();
                while (line != null &&  aux < 100)
                { 
                    division = line.Split(',');
                    fillCells(getDoubles(division), aux);
                    line = sr.ReadLine();
                    aux++;
                }
                sr.Close();
            }
            else if (comb == 2)
            {
                StreamReader sr = new StreamReader("iris.txt");
                aux = 0; int row = 0;
                line = sr.ReadLine();
                while (line != null && row < 100 && aux < 150)
                {
                    if (aux < 50 || aux > 99)
                    {
                        division = line.Split(',');
                        fillCells(getDoubles(division), row);
                        row++;
                    }
                    line = sr.ReadLine();
                    aux++;
                }
                sr.Close();
            }
            else
            {
                StreamReader sr = new StreamReader("iris.txt");
                aux = 0; int row = 0;
                line = sr.ReadLine();
                while (line != null && row < 100 && aux < 150)
                {
                    if (aux > 49)
                    {
                        division = line.Split(',');
                        fillCells(getDoubles(division), row);
                        row++;
                    }
                    line = sr.ReadLine();
                    aux++;
                }
                sr.Close();
            }
            pintaColum(true);
        }
        private void cbplants_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbplants.SelectedIndex;

            dgverdad.Columns.Clear();
            lbresultados.Items.Clear();

            switch (index)
            {
                case 0:
                    createTable();
                    fillTable(1);
                    break;
                case 1:
                    createTable();
                    fillTable(2);
                    break;
                case 2:
                    createTable();
                    fillTable(3);
                    break;
                default:
                    break;
            }
        }

        private void btperceptron_Click(object sender, EventArgs e)
        {
            double[] peso = new double[entrada];
            int fila = 0, epoca = 1;
            double ycalc, aux;
            bool esIgual = true, correcto = false;

            peso = generaAleatorios();
            imprimeList(peso, epoca, false);
            lbresultados.Items.Add("Epoca = " + epoca.ToString());
            lbresultados.Items.Add("");

            while (fila != dgverdad.Rows.Count && epoca < 52)
            {
                ycalc = evalua(peso, fila);
                lbresultados.Items.Add("Entrada: " + fila.ToString());
                esIgual = verifica(ycalc, fila);

                if (esIgual) { }
                else
                    peso = aprendizaje(peso, _clase, fila);

                fila++;
                if (fila == dgverdad.Rows.Count)
                {
                    if (verificaResultado(peso))
                    {
                        correcto = true;
                        imprimeList(peso, epoca, false);
                        break;
                    }
                    else
                    {
                        fila = 0;
                        epoca += 1;
                        imprimeList(peso, epoca, false);
                        lbresultados.Items.Add("Epoca = " + epoca.ToString());
                        lbresultados.Items.Add("");
                    }
                }
                if (epoca > 50)
                {
                    MessageBox.Show("Parametros NO encontrados");
                    correcto = false;
                    break;
                }
                imprimeList(peso, epoca, false);
            }

            if (correcto)
            {
                for (int j = 0; j < dgverdad.Rows.Count; j++)
                    dgverdad.Rows[j].Cells[entrada + 1].Value = dgverdad.Rows[j].Cells[entrada].Value;
            }
            else
            {
                for (int j = 0; j < dgverdad.Rows.Count; j++)
                {
                    aux = evalua(peso, j);
                    dgverdad.Rows[j].Cells[entrada + 1].Value = aux > 0 ? 1 : -1;
                }
            }

            pintaColum(false);
            lbresultados.Items.Add("");
            lbresultados.Items.Add("Parametros finales:");
            imprimeList(peso, epoca, true);
        }
        public void imprimeList(double[] peso, int epoca, bool impEpc)
        {
            if (impEpc)
            {
                for (int i = 0; i < entrada - 1; i++)
                    lbresultados.Items.Add("W[" + i.ToString() + "]" + " = " + peso[i].ToString());

                lbresultados.Items.Add("Umbral = " + umbral.ToString());
                lbresultados.Items.Add("Epocas: " + epoca.ToString());
            }
            else
            {
                for (int i = 0; i < entrada - 1; i++)
                    lbresultados.Items.Add("W[" + i.ToString() + "]" + " = " + peso[i].ToString());

                lbresultados.Items.Add("Umbral = " + umbral.ToString());
            }
            lbresultados.Items.Add("");
        }
        public bool verificaResultado(double[] peso)
        {
            double ycalc;

            for (int j = 0; j < dgverdad.Rows.Count; j++)
            {
                ycalc = evalua(peso, j);
                if (verifica(ycalc, j))
                    continue;
                else
                    return false;
            }
            return true;
        }
        public double[] aprendizaje(double[] peso, char clase, int fila)
        {
            double delta = clase == 'A' ? -1 : 1;
            double[] newpesos = new double[entrada];
            double[] deltax = new double[entrada];

            for (int i = 0; i < peso.Length; i++)
            {
                deltax[i] = delta * Convert.ToDouble(dgverdad.Rows[fila].Cells[i+1].Value);
            }
            for (int i = 0; i < peso.Length; i++)
            {
                newpesos[i] = deltax[i] + peso[i];
            }
            umbral += delta;

            return newpesos;
        }
        public bool verifica(double value, int fila)
        {
            _clase = Convert.ToDouble(dgverdad.Rows[fila].Cells[entrada].Value) == -1 ? 'A' : 'B';
            value = value > 0 ? 1 : -1;
            return value == Convert.ToDouble(dgverdad.Rows[fila].Cells[entrada].Value);
        }

        public double evalua(double[] peso, int fila)
        {
            double ycalc = 0;

            for (int i = 0; i < entrada - 1; i++)
            {
                ycalc += peso[i] * Convert.ToDouble(dgverdad.Rows[fila].Cells[i+1].Value);
            }
            ycalc += umbral;
            return ycalc;
        }
        public double[] generaAleatorios()
        {
            double[] pesos = new double[entrada - 1];
            Random aleat = new Random();

            for (int i = 0; i < entrada - 1; i++)
            {
                pesos[i] = Math.Round(aleat.NextDouble(), 2);
            }
            umbral = Math.Round(aleat.NextDouble(), 2);

            return pesos;
        }
        public void pintaColum(bool y)
        {
            for (int j = 0; j < dgverdad.Rows.Count; j++)
            {
                if (y)
                    dgverdad.Rows[j].Cells[entrada].Style.BackColor = Color.Beige;
                else
                    dgverdad.Rows[j].Cells[entrada + 1].Style.BackColor = Color.LightSkyBlue;
            }
        }

    }
}
