using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neurona
{
    public partial class Form1 : Form
    {
        int entrada = 0, comb_z = 0, comb_o = 0, cols, rows;
        double combinaciones; decimal sum, umbral;
        string column_name = "";
        bool zeros = true, ones = false;
        decimal[] pesos;

        public Form1()
        {
            InitializeComponent();
        }
        private void btlimpia_Click(object sender, EventArgs e)
        {
            //limpia las filas de las tablas y los textBox
            dgvpesos.Rows.Clear();
            dgvverdad.Rows.Clear();
            tbumbral.Text = "0";
            tbentradas.Text = "0";
        }
        private void btneurona_Click(object sender, EventArgs e)
        {
            if (ObtenerUmbral() && entrada > 0)
            {
                pesos = new decimal[entrada]; // vector para almacenar pesos de tamano del num. de entradas

                //obtener los datos del dgvpesos y almacenarlos en el vector pesos
                for (int j = 0; j < entrada; j++)
                {
                    pesos[j] = Convert.ToDecimal(dgvpesos.Rows[j].Cells[0].Value);
                }

                //**Sumatoria**

                //umbral = Convert.ToDouble(tbumbral.Text); //valor del umbral
                for (int j = 0; j < rows; j++)
                {
                    sum = 0;
                    for (int i = 0; i < cols; i++)
                    {
                        sum += Convert.ToDecimal(dgvverdad.Rows[j].Cells[i].Value) * pesos[i];
                    }
                    //MessageBox.Show(sum.ToString());
                    if (sum <= umbral)
                        dgvverdad.Rows[j].Cells[cols].Value = 0;
                    else if (sum > umbral)
                        dgvverdad.Rows[j].Cells[cols].Value = 1;
                }

                //pintar celdas de la salida
                for (int j = 0; j < rows; j++)
                {
                    dgvverdad.Rows[j].Cells[cols].Style.BackColor = Color.LightSkyBlue;
                }
            }
            else
            {
                
            }
            


        }
        private void bttabla_Click(object sender, EventArgs e)
        {
            if (Entrada())
            {
                if (entrada > 0)
                {
                    dgvverdad.Columns.Clear();
                    dgvpesos.Rows.Clear();
                    dgvpesos.Columns.Clear();

                    //**se anaden las columnas con sus respectivos nombres
                    for (int i = entrada; i > 0; i--)
                    {
                        column_name = "X".Insert(1, i.ToString());
                        dgvverdad.Columns.Add("entrada".Insert(7, i.ToString()), column_name);
                    }
                    dgvverdad.Columns.Add("salida", "Y");

                    //****llenado de tabla de verdad****

                    //se agregan las filas
                    combinaciones = Math.Pow(2, (double)entrada);
                    for (int i = 0; i < combinaciones - 1; i++)
                    {
                        dgvverdad.Rows.Add();
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
                                dgvverdad.Rows[j].Cells[i].Value = 0;
                                comb_z += 1;
                            }
                            else if (ones)
                            {
                                dgvverdad.Rows[j].Cells[i].Value = 1;
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

                    //***llenado de tabla de pesos****

                    // se agrega la columna de pesos
                    dgvpesos.Columns.Add("pesos", "Pesos");

                    //se agregan las filas
                    for (int i = 0; i < entrada - 1; i++) // -1 porque el dgv agrega por si mismo una fila de mas
                    {
                        dgvpesos.Rows.Add();
                    }
                }
                else
                {
                    MessageBox.Show("Entrada Invalida");
                }
            }
            else
            {
               
            }

        }
        private bool Entrada()
        {
            try
            {
                entrada = int.Parse(tbentradas.Text);
                return true;
            }
            catch
            {
                MessageBox.Show("Ingresa un No. de Entradas correctas");
                return false;
            }
            
        }
        private bool ObtenerUmbral()
        {
            try
            {
                umbral = Convert.ToDecimal(tbumbral.Text);
                return true;
            }
            catch
            {
                MessageBox.Show("Ingresa un valor de Umbral");
                return false;
            }
        }
    }
}
