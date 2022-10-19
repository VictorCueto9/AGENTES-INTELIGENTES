using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perceptron
{
    public partial class Form1 : Form
    {
        string column_name = "";
        char _clase;
        double combinaciones, umbral;
        int cols, rows, comb_z = 0, comb_o = 0, entrada;
        bool zeros = true, ones = false, esIgual = true, correcto =  false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btperceptron_Click(object sender, EventArgs e)
        {
            double[] peso = new double[entrada];
            int fila = 0, epoca = 1;
            double ycalc, aux;

            peso = generaAleatorios();
            imprimeList(peso, epoca, false);
            lbresultados.Items.Add("Epoca = " + epoca.ToString());
            lbresultados.Items.Add("");

            while (fila != dgverdad.Rows.Count && epoca < 100)
            {
                ycalc = evalua(peso, fila);
                lbresultados.Items.Add("Entrada: "+fila.ToString());
                esIgual = verifica(ycalc, fila);
                if (esIgual)
                {
                }
                else
                {
                    peso = aprendizaje(peso, _clase, fila);
                }
                fila++;
                if(fila == dgverdad.Rows.Count)
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
                if(epoca >= 100)
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
                {
                    dgverdad.Rows[j].Cells[entrada + 1].Value = dgverdad.Rows[j].Cells[entrada].Value;
                }
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
                for (int i = 0; i < entrada; i++)
                {
                    lbresultados.Items.Add("W[" + i.ToString() + "]" + " = " + peso[i].ToString());
                }
                lbresultados.Items.Add("Umbral = " + umbral.ToString());
                lbresultados.Items.Add("Epocas: " + epoca.ToString());
            }
            else
            {
                for (int i = 0; i < entrada; i++)
                {
                    lbresultados.Items.Add("W[" + i.ToString() + "]" + " = " + peso[i].ToString());
                }
                lbresultados.Items.Add("Umbral = " + umbral.ToString());
            }
            lbresultados.Items.Add("");
        }
        public bool verificaResultado(double[] peso)
        {
            double ycalc;

            for(int j = 0; j < dgverdad.Rows.Count; j++)
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
                deltax[i] = delta * Convert.ToDouble(dgverdad.Rows[fila].Cells[i].Value);
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

        private void btclear_Click(object sender, EventArgs e)
        {
            dgverdad.Columns.Clear();
            lbresultados.Items.Clear();
        }

        public double evalua(double[] peso, int fila)
        {
            double ycalc = 0;

            for(int i = 0; i < entrada; i++)
            {
                ycalc += peso[i] * Convert.ToDouble(dgverdad.Rows[fila].Cells[i].Value);
            }
            ycalc += umbral;
            return ycalc;
        }
        public double[] generaAleatorios()
        {
            double[] pesos = new double[entrada];
            Random aleat = new Random();
            for(int i = 0; i < entrada; i++)
            {
                pesos[i] = Math.Round(aleat.NextDouble(),2);
            }
            umbral = Math.Round(aleat.NextDouble(), 2);

            return pesos;
        }

        public void generaTabla(int ent, string comp)
        {
            dgverdad.Columns.Clear();

            //**se anaden las columnas con sus respectivos nombres
            for (int i = ent; i > 0; i--)
            {
                column_name = "X".Insert(1, i.ToString());
                dgverdad.Columns.Add("entrada".Insert(7, i.ToString()), column_name);
            }
            dgverdad.Columns.Add("yesp", "Yesp");
            dgverdad.Columns.Add("ycalc", "Ycalc");

            //****llenado de tabla de verdad****

            //se agregan las filas
            combinaciones = Math.Pow(2, (double)ent);
            for (int i = 0; i < combinaciones - 1; i++)
            {
                dgverdad.Rows.Add();
            }

            //llenar con zeros y ones
            cols = ent; rows = (int)combinaciones;
            double power = (double)cols;
            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if (zeros)
                    {
                        dgverdad.Rows[j].Cells[i].Value = 0;
                        comb_z += 1;
                    }
                    else if (ones)
                    {
                        dgverdad.Rows[j].Cells[i].Value = 1;
                        comb_o += 1;
                    }

                    if (comb_z >= Math.Pow(2, power - 1))
                    {
                        zeros = false;
                        ones = true;
                        comb_z = 0;
                    }
                    else if (comb_o >= Math.Pow(2, power - 1))
                    {
                        zeros = true;
                        ones = false;
                        comb_o = 0;
                    }

                }
                power--;
            }
            entrada = ent;
            decimal[] w = new decimal[entrada];
            w[0] = 1;
            w[1] = 1;
            switch (comp)
            {
                case "and":
                    Yesperada(w, 1);
                    break;
                case "or":
                    Yesperada(w, 0);
                    break;
                case "xor":
                    llenaXor();
                    break;
                case "may":
                    llenaMayoria();
                    break;
                case "par":
                    llenaParidad();
                    break;
                case "ejem":
                    llenaEjemplo();
                    break;
                default:
                    break;
            }
        }
        private void cbproblema_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbproblema.SelectedIndex;
            
            switch (index)
            {
                case 0:
                    generaTabla(2, "and");
                    break;
                case 1:
                    generaTabla(2, "or");
                    break;
                case 2:
                    generaTabla(2,"xor");
                    break;
                case 3:
                    generaTabla(3, "may");
                    break;
                case 4:
                    generaTabla(4, "par");
                    break;
                case 5:
                    generaTabla(2, "ejem");
                    break;
                default:
                    break;
            }
        }
        public void Yesperada(decimal[] pesos, decimal umbral) //para llenar las compuertas AND y OR
        {
            decimal sum;

            //**Sumatoria**
            for (int j = 0; j < rows; j++)
            {
                sum = 0;
                for (int i = 0; i < cols; i++)
                {
                    sum += Convert.ToDecimal(dgverdad.Rows[j].Cells[i].Value) * pesos[i];
                }

                if (sum <= umbral)
                    dgverdad.Rows[j].Cells[cols].Value = -1;
                else if (sum > umbral)
                    dgverdad.Rows[j].Cells[cols].Value = 1;
            }

            //pintar celdas de la salida
            pintaColum(true);
        }
        public void llenaXor()
        {
            for (int j = 0; j < rows; j++)
            {
                if (j == 1 || j==2)
                    dgverdad.Rows[j].Cells[2].Value = 1;
                else
                    dgverdad.Rows[j].Cells[2].Value = -1;
            }

            //pintar celdas de la salida
            pintaColum(true);
        }
        public void llenaMayoria()
        {
            int valor, c_ones, c_zeros;
            for(int j = 0; j < rows; j++)
            {
                c_ones = 0; c_zeros = 0;
                for(int i = 0; i < cols; i++)
                {
                    valor = Convert.ToInt32(dgverdad.Rows[j].Cells[i].Value);
                    if (valor == 1)
                        c_ones += 1;
                    else
                        c_zeros += 1;
                }
                if (c_ones > c_zeros)
                    dgverdad.Rows[j].Cells[cols].Value = 1;
                else
                    dgverdad.Rows[j].Cells[cols].Value = -1;
            }

            //pintar celdas de la salida
            pintaColum(true);
        }
        public void llenaParidad()
        {
            int valor, c_ones;
            for (int j = 0; j < rows; j++)
            {
                c_ones = 0;
                for (int i = 0; i < cols; i++)
                {
                    valor = Convert.ToInt32(dgverdad.Rows[j].Cells[i].Value);
                    if (valor == 1)
                        c_ones += 1;
                }
                if (c_ones != 0 && c_ones % 2 == 0)
                    dgverdad.Rows[j].Cells[cols].Value = 1;
                else
                    dgverdad.Rows[j].Cells[cols].Value = -1;
            }

            //pintar celdas de la salida
            pintaColum(true);
        }
        public void llenaEjemplo()
        {
            dgverdad.Columns.Clear();

            //**se anaden las columnas con sus respectivos nombres
            for (int i = 2; i > 0; i--)
            {
                column_name = "X".Insert(1, i.ToString());
                dgverdad.Columns.Add("entrada".Insert(7, i.ToString()), column_name);
            }
            dgverdad.Columns.Add("yesp", "Yesp");
            dgverdad.Columns.Add("ycalc", "Ycalc");

            for (int i = 0; i < 6 - 1; i++)
            {
                dgverdad.Rows.Add();
            }
            dgverdad.Rows[0].Cells[0].Value = 2;
            dgverdad.Rows[0].Cells[1].Value = 0;
            dgverdad.Rows[1].Cells[0].Value = 0;
            dgverdad.Rows[1].Cells[1].Value = 0;
            dgverdad.Rows[2].Cells[0].Value = 2;
            dgverdad.Rows[2].Cells[1].Value = 2;
            dgverdad.Rows[3].Cells[0].Value = 0;
            dgverdad.Rows[3].Cells[1].Value = 1;
            dgverdad.Rows[4].Cells[0].Value = 1;
            dgverdad.Rows[4].Cells[1].Value = 1;
            dgverdad.Rows[5].Cells[0].Value = 1;
            dgverdad.Rows[5].Cells[1].Value = 2;

            //yesp
            for (int j = 0; j < 6; j++)
            {
                if (j % 2 == 0)
                    dgverdad.Rows[j].Cells[2].Value = 1;
                else
                    dgverdad.Rows[j].Cells[2].Value = -1;
            }
            pintaColum(true);

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
