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
            if (rbxor.Checked)
            {
                Red XOR = new Red();
                XOR = netXOR(XOR);
                activeNet(XOR);
            }
            else
            {
                Red EJERCICIO = new Red();
                EJERCICIO = netEJERCICIO(EJERCICIO);
                activeNet(EJERCICIO);
            }

        }
        public void colorOutput(Red red)
        {
            for (int j = 0; j < dgverdad.Rows.Count; j++)
            {
                for (int i = red.inputs; i < dgverdad.Columns.Count; i++)
                    dgverdad.Rows[j].Cells[i].Style.BackColor = Color.Beige;
            }
        }
        public Red netEJERCICIO(Red red)
        {
            int entradas = 2, salidas = 2;
            createTable(entradas, salidas);

            double[] valEntradas = new double[entradas];
            for (int i = 0; i < entradas; i++) // se toman las entradas de la fila 0
                valEntradas[i] = Convert.ToDouble(dgverdad.Rows[0].Cells[i].Value);

            //Crear la Red

            red = new Red() { capa = 4, inputs = 2 };

            int[] numNeuronas = new int[] { 2, 2, 2 }; //a partir de capa 1

            red.createUmbral(numNeuronas);
            for (int i = 0; i < red.listCapas.Count; i++) //se llenan los vectores de los umbrales de cada capa
                red.fillUmbral(0.5, i);

            red.insertInput(valEntradas);

            red.createPesos();
            for (int i = 0; i < red.listPesos.Count; i++)
                red.fillPesos(1, i);

            return red;
        }
        public Red netXOR(Red red)
        {
            int entradas = 2, salidas = 1;
            createTable(entradas, salidas);

            double[] valEntradas = new double[entradas];
            for (int i = 0; i < entradas; i++) // se toman las entradas de la fila 0
                valEntradas[i] = Convert.ToDouble(dgverdad.Rows[0].Cells[i].Value);

            //Crear la Red

            red = new Red() { capa = 3, inputs = 2 };

            int[] numNeuronas = new int[] { 2, 1 }; //a partir de capa 1
            List<double[]> listUmbral = new List<double[]> { new double[] { -1.90289, -4.127002 }, new double[] { -2.570539 } };
            List<double[,]> listPesos = new List<double[,]> { new double[,] { { 5.191129, 2.758669 }, { 5.473012, 2.769596 } }, new double[,] { { 5.839709 }, { -6.186834 } } };
            //IMPORTANTE: el tamano de las matrices en listPesos debe ser de tamano_vectorUmbral_capa_n x tamano_vectorUmbral_capa_n+1
            //o de otra forma: no_neuronas_capa_n x no_neuronas_capa_n+1
            //solo hacerlo cuando los valores de los pesos son predeterminados

            red.createUmbral(numNeuronas);
            for (int i = 0; i < listUmbral.Count; i++) //se llenan los vectores de los umbrales de cada capa
                red.fillUmbral(listUmbral[i], i);

            red.insertInput(valEntradas);

            red.createPesos();
            for (int i = 0; i < listPesos.Count; i++)
                red.fillPesos(listPesos[i], i);

            return red;
        }
        private void activeNet(Red red)
        {
            int entradas = red.listCapas[0].Umbral.Length;
            double[] valEntradas = new double[entradas];
            int fila = 1;
            lbres.Items.Clear();

            //pasar las entradas a la Red y activar las neuronas
            while (fila <= dgverdad.Rows.Count)
            {
                lbres.Items.Add("Patrón no. " + fila);
                lbres.Items.Add("");
                for (int i = 1; i < red.capa; i++)
                {
                    lbres.Items.Add("Capa No. " + i);
                    lbres.Items.Add("");
                    red.activaNeurona(i, "sigmoide");
                    for (int j = 0; j < red.listActive[i - 1].Length; j++)
                        lbres.Items.Add("C(" + i + ").ac(" + j + ") = " + red.listActive[i - 1][j]);
                    if (i == red.capa - 1)
                    {
                        lbres.Items.Add("");
                        lbres.Items.Add("Salida del patrón " + fila + ":");
                        lbres.Items.Add("");
                        for (int j = 0; j < red.listActive[i - 1].Length; j++)
                        {
                            lbres.Items.Add("y(" + j + ") = " + red.listActive[i - 1][j]);
                            for (int sal = entradas; sal < dgverdad.Columns.Count; sal++)
                                dgverdad.Rows[fila - 1].Cells[sal].Value = red.listActive[i - 1][j];
                        }
                    }
                    lbres.Items.Add("");
                }
                if (fila == dgverdad.Rows.Count) break;
                red.listActive.Clear();
                red.deleteInput();
                for (int i = 0; i < entradas; i++)
                    valEntradas[i] = Convert.ToDouble(dgverdad.Rows[fila].Cells[i].Value);
                red.insertInput(valEntradas);
                fila++;
            }

            colorOutput(red);
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
            for (int i = 0; i < salidas; i++)
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
}