using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perceptron_Multicapa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int fila = 1;
            int entradas = 2, salidas = 1;
            createTable(entradas, salidas);

            double[] valEntradas = new double[entradas];
            //double[] valEntradas = new double[] {0,0};
            for (int i = 0; i < entradas; i++)
                valEntradas[i] = Convert.ToDouble(dgverdad.Rows[0].Cells[i].Value);

            //crear la Red

            Red red = new Red() { capa = 3 };

            int[] numNeuronas = new int[] { 2, 1 };
            List<double[]> listUmbral = new List<double[]> { new double[] { -1.90289, -4.127002 }, new double[] { -2.570539 } };
            List<double[,]> listPesos = new List<double[,]> { new double[,] { { 5.191129, 2.758669 }, { 5.473012, 2.769596 } }, new double[,] { { 5.839709 }, { -6.186834 } } };

            red.createUmbral(numNeuronas);
            for (int i = 0; i < listUmbral.Count; i++)
                red.fillUmbral(listUmbral[i], i);

            red.insertInput(valEntradas);

            red.createPesos();
            for (int i = 0; i < listPesos.Count; i++)
                red.fillPesos(listPesos[i], i);

            //pasar las entradas a la Red y activar las neuronas

            lbres.Items.Add("active:");

            while (fila <= dgverdad.Rows.Count)
            {
                for (int i = 1; i < red.capa; i++)
                    red.activaNeurona(i, "sigmoide");
                for (int i = 0; i < red.listActive.Count; i++)
                {
                    foreach (double val in red.listActive[i])
                    {
                        lbres.Items.Add(val);
                    }
                }
                if (fila == dgverdad.Rows.Count) break;
                red.listActive.Clear();
                red.deleteInput();
                for (int i = 0; i < entradas; i++)
                    valEntradas[i] = Convert.ToDouble(dgverdad.Rows[fila].Cells[i].Value);
                red.insertInput(valEntradas);
                fila++;
            }


        }
        private void createTable(int entrada, int salidas)
        {
            dgverdad.Columns.Clear();
            int comb_z = 0, comb_o = 0, cols, rows;
            double combinaciones;
            string column_name = "";
            bool zeros = true, ones = false;

            //**se anaden las columnas con sus respectivos nombres
            for (int i = entrada; i > 0; i--)
            {
                column_name = "X".Insert(1, i.ToString());
                dgverdad.Columns.Add("entrada".Insert(7, i.ToString()), column_name);
            }
            //dgverdad.Columns.Add("salida", "Y"); Se anaden las salidas
            for(int i = 0; i < salidas; i++)
            {
                column_name = "Y".Insert(1, (i + 1).ToString());
                dgverdad.Columns.Add("salida".Insert(6, i.ToString()), column_name);
            }

            //****llenado de tabla de verdad****

            //se agregan las filas
            combinaciones = Math.Pow(2, (double)entrada);
            for (int i = 0; i < combinaciones - 1; i++)
            {
                dgverdad.Rows.Add();
            }

            //llenar con zeros y ones
            cols = entrada; rows = (int)combinaciones;
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
        }
    }
    public class Capa
    {
        public int neuronas { get; set; }
        public double[] Umbral { get; set; }

    }
    public class Peso
    {
        public double[,] W { get; set; }

    }
    public class Red
    {
        public double[] entradas { get; set; }
        public int capa { get; set; }
        public List<Capa> listCapas { get; set; }
        public List<Peso> listPesos { get; set; }
        public List<double[]> listActive { get; set; }

        public Red() //parametros de los valores de las entradas y cuantas capas tiene la red
        {
            listCapas = new List<Capa>();
            listPesos = new List<Peso>();
            listActive = new List<double[]>();
        }
        public void insertInput(double[] ints)
        {
            entradas = ints;
            listCapas.Insert(0, new Capa() { neuronas = entradas.Length, Umbral = entradas }); //capa 0
        }
        public void deleteInput()
        {
            listCapas.RemoveAt(0);
        }
        public void createUmbral(int[] numNeuro) //a partir de capa 1, parametro = numero de neuronas
        {
            for (int i = 0; i < capa - 1; i++)
            {
                listCapas.Add(new Capa() { neuronas = numNeuro[i] });
            }
        }
        public void fillUmbral(double[] valuesUmbral, int capaU) //parametro vector con los valores de cada neurona y en que capa
        {
            listCapas[capaU].Umbral = valuesUmbral;
        }
        public void createPesos()
        {
            for(int i = 0; i < listCapas.Count - 1; i++)
            {
                listPesos.Add(new Peso() { W = new double[listCapas[i].Umbral.Length, listCapas[i + 1].Umbral.Length] });
            }
        }
        public void fillPesos(double w, int capa) //llena todos los pesos de un solo valor
        {
            for (int i = 0; i < listPesos[capa].W.GetUpperBound(0) + 1; i++) //filas
            {
                for (int j = 0; j < listPesos[capa].W.GetUpperBound(1) + 1; j++) //columnas
                {
                    listPesos[capa].W.SetValue(w, i, j);
                }
            }
        }
        public void fillPesos(double[,] w, int capa) //lena los pesos recibiendo una matriz
        {
            listPesos[capa].W = w;
        }
        public void activaNeurona(int capa, string funcion)
        {
            double[] active = new double[listCapas[capa].Umbral.Length];
            int aux = 0; double sum = 0;

            for(int j = 0; j < listCapas[capa].Umbral.Length; j++)
            {
                for (int i = 0; i < listCapas[capa - 1].Umbral.Length; i++)
                {
                    sum += capa == 1 ? listCapas[capa - 1].Umbral[i] * listPesos[capa - 1].W[i, j] : listActive[capa - 2][i] * listPesos[capa - 1].W[i, j];
                }
                sum += listCapas[capa].Umbral[aux];
                sum = funcion == "sigmoide" ? Sigmoide(sum) : Math.Tanh(sum);
                active[aux] = sum;
                sum = 0; aux++;
            }

            listActive.Add(active);
        }
        private double Sigmoide (double x)
        {
            return 1 / (1 + Math.Exp(-x));
        }
    }
    
}
