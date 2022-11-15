using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Perceptron_Backpropagation
{
    public partial class Form1 : Form
    {
        string column_name = "";
        double combinaciones;
        int cols, rows, comb_z = 0, comb_o = 0, entrada, capas, capas_ocultas, epocas; double sum_err;
        bool zeros = true, ones = false;
        double alpha, error;
        public Form1()
        {
            InitializeComponent();
        }

        private void btcrear_Click(object sender, EventArgs e)
        {
            dgvcapsocul.Rows.Clear();
            capas_ocultas = int.Parse(tbcrear.Text);
            //se agregan las filas
            for (int i = 0; i < capas_ocultas - 1; i++) // -1 porque el dgv agrega por si mismo una fila de mas
            {
                dgvcapsocul.Rows.Add();
                dgvcapsocul.Rows[i].Cells[0].Value = i + 1;
            }
            dgvcapsocul.Rows[dgvcapsocul.RowCount - 1].Cells[0].Value = dgvcapsocul.RowCount;
        }
        public void printUW(Red red)
        {
            for (int i = 0; i < red.listCapas.Count; i++)
            {
                lbres.Items.Add("umbral " + i + ":");
                for (int j = 0; j < red.listCapas[i].neuronas; j++)
                {
                    lbres.Items.Add("[" + j + "] = " + red.listCapas[i].Umbral[j]);
                }
            }

            lbres.Items.Add("Pesos matrix");

            for (int i = 0; i < red.listPesos.Count; i++)
            {
                lbres.Items.Add("Pesos " + i + ":");
                for (int j = 0; j < red.listPesos[i].W.GetUpperBound(0) + 1; j++) //filas
                {
                    for (int k = 0; k < red.listPesos[i].W.GetUpperBound(1) + 1; k++) //columnas
                    {
                        lbres.Items.Add("[" + j + "][ " + k + " ] = " + red.listPesos[i].W.GetValue(j, k));
                    }
                }
            }
        }
        private void btback_Click(object sender, EventArgs e)
        {
            printDGV();
            Entrada();

            Red red = new Red();

            red = createNet(red);
            red = activeNet(red);
        }
        public void colorOutputcalc(Red red)
        {
            for(int j = 0; j < dgverdad.Rows.Count; j++)
            {
                for (int i = red.inputs + red.outputs; i < dgverdad.ColumnCount; i++)
                    dgverdad.Rows[j].Cells[i].Style.BackColor = Color.GreenYellow;
            }
        }
        public void calcDelta(Red red)
        {
            lbres.Items.Add("CALC DELTAS FILA 0:");

            for (int i = 0; i < red.listDeltas.Count; i++)
            {
                lbres.Items.Add("deltas " + i + ":");
                for (int j = 0; j < red.listDeltas[i].Length; j++)
                {
                    lbres.Items.Add("[" + j + "] = " + red.listDeltas[i][j]);
                }
            }
        }
        public Red updatePesos(Red red)
        {
            int aux = 0; double w; //debe de agregarse la capa e entrada a la lista listActive en index = 0
            for(int i = red.listPesos.Count - 1; i >= 0; i--)
            {
                for (int j = 0; j < red.listPesos[i].W.GetUpperBound(0) + 1; j++) //filas
                {
                    for (int k = 0; k < red.listPesos[i].W.GetUpperBound(1) + 1; k++) //columnas
                    {
                        w = Convert.ToDouble(red.listPesos[i].W.GetValue(j, k)) - (alpha * red.listDeltas[aux][k] * red.listActive[i][j]);
                        red.listPesos[i].W.SetValue(w, j, k);
                    }
                }
                aux++;
            }

            return red;
        }
        public Red updateUmbral(Red red)
        {
            int aux = 0;
            for(int i = red.listCapas.Count - 1; i > 0; i--)  //todavia uncluye la entrada
            {
                for(int j = 0; j < red.listCapas[i].neuronas; j++)
                    red.listCapas[i].Umbral[j] = red.listCapas[i].Umbral[j] - (alpha * red.listDeltas[aux][j]);
                aux++;
            }

            return red;
        }
        public Red calcDeltaValues(Red red, int fila)
        {
            double[] yesp = new double[red.outputs];
            double[] deltaOut = new double[red.outputs];
            int aux1 = 0;int aux2 = 0;
            for (int j = red.inputs; j < dgverdad.ColumnCount - red.outputs; j++)
            {
                yesp[aux1] = Convert.ToDouble(dgverdad.Rows[fila].Cells[j].Value);
                aux1++;
            }

            for (int i = red.listActive.Count - 1; i >= 0; i--)
            {
                if (i == red.listActive.Count - 1)
                {
                    for (int k = 0; k < red.listActive[i].Length; k++)
                    {
                        deltaOut[k] = -(yesp[k] - red.listActive[i][k]) * (red.listActive[i][k]) * (1 - red.listActive[i][k]);
                    }
                    red.listDeltas.Add(deltaOut);
                }
                else
                {
                    int size = red.listActive[i].Length; double sum = 0;
                    double[] delta = new double[size];
                    for(int j = 0; j < size; j++)
                    {
                        for (int l = 0; l < red.listPesos[i + 1].W.GetUpperBound(1) + 1; l++) //recorre columnas del peso
                        {
                            sum += red.listPesos[i + 1].W[j, l] * red.listDeltas[aux2][l];
                        }
                        delta[j] = (red.listActive[i][j]) * (1 - red.listActive[i][j]) * sum;
                        sum = 0;
                    }
                    red.listDeltas.Add(delta);
                    aux2++;
                }
            }

            return red;
        }
        public Red createNet(Red red)
        {
            int outputs, inputs;

            for (int i = 0; i < dgvcapsocul.Rows.Count - 1; i++)
                red.addUmbral(Convert.ToInt32(dgvcapsocul.Rows[i].Cells[1].Value));

            red.addUmbral(outputs = calcOutputs());
            red.fillUmbral();

            double[] valEntradas = new double[ inputs = calcInputs()];
            for (int i = 0; i < inputs; i++) // se toman las entradas de la fila 0
                valEntradas[i] = Convert.ToDouble(dgverdad.Rows[0].Cells[i].Value);

            red.insertInput(valEntradas);
            red.createPesos();
            red.fillPesos();

            red.inputs = inputs; red.outputs = outputs; red.capa = capas_ocultas + 2; //+2 por la capa de entrada y capa de salida

            return red;
        }
        public double[] calcError(Red red, int fila)
        {
            double[] error = new double[red.outputs];
            double[] yesp = new double[red.outputs];
            int aux1 = 0;
            for (int j = red.inputs; j < dgverdad.ColumnCount - red.outputs; j++)
            {
                yesp[aux1] = Convert.ToDouble(dgverdad.Rows[fila].Cells[j].Value);
                aux1++;
            }

            for (int i = 0; i < yesp.Length; i++)
            {
                error[i] = (0.5) * Math.Pow((yesp[i] - red.listActive[red.listActive.Count - 1][i]),2);
            }

            return error;
        }
        private Red activeNet(Red red)
        {
            int entradas = red.listCapas[0].neuronas; double E = 0; int epoca = 1;
            double[] valEntradas = new double[entradas];
            int fila = 1;
            double[] Errors = new double[dgverdad.Rows.Count];
            double[] errors_capa;
            lbres.Items.Clear();

            //pasar las entradas a la Red y activar las neuronas
            while (fila <= dgverdad.Rows.Count)
            {
                for (int i = 1; i < red.capa; i++)
                {
                    red.activaNeurona(i, "sigmoide");
                    if (i == red.capa - 1)
                    {
                        for (int j = 0; j < red.listActive[i - 1].Length; j++)
                        {
                            for (int sal = red.inputs + red.outputs ; sal < dgverdad.Columns.Count; sal++)
                                dgverdad.Rows[fila - 1].Cells[sal].Value = red.listActive[i - 1][j];
                        }
                    }
                }

                errors_capa =  calcError(red, fila - 1);
                foreach (double e in errors_capa)
                    Errors[fila - 1] += e;

                if (fila == dgverdad.Rows.Count)
                {
                    foreach (double e in Errors)
                        E += e;
                    sum_err = E / Errors.Length;
                    if (sum_err <= error)
                    {
                        lbres.Items.Add("Salida por error");
                        lbres.Items.Add("Epocas: " + epoca);
                        lbres.Items.Add("e = " + sum_err);
                        break;
                    }
                    else
                    {
                        red = calcDeltaValues(red, fila - 1);
                        red = updateUmbral(red);
                        red.listActive.Insert(0, red.listCapas[0].Umbral); //inserta la entrada en la listActive
                        red = updatePesos(red);

                        fila = 1; E = 0; epoca++;

                        red.listActive.Clear();
                        red.listDeltas.Clear();

                        for (int p = 0; p < Errors.Length; p++) Errors[p] = 0;

                        red.deleteInput(); //se borra la entrada

                        for (int i = 0; i < entradas; i++)
                            valEntradas[i] = Convert.ToDouble(dgverdad.Rows[0].Cells[i].Value); //se anade la entrada de la fila 0
                        red.insertInput(valEntradas);

                        continue;
                    }
                }

                if(epoca >= epocas)
                {
                    lbres.Items.Add("Salida por Epoca");
                    lbres.Items.Add("Epocas: " + epoca);
                    lbres.Items.Add("e = " + sum_err);
                    break;
                }

                red = calcDeltaValues(red, fila-1);

                red = updateUmbral(red);
                red.listActive.Insert(0, red.listCapas[0].Umbral); //inserta la entrada en la listActive
                red = updatePesos(red);

                red.deleteInput();

                red.listDeltas.Clear();
                red.listActive.Clear();

                for (int i = 0; i < entradas; i++)
                    valEntradas[i] = Convert.ToDouble(dgverdad.Rows[fila].Cells[i].Value);
                red.insertInput(valEntradas);
                fila++;
            }
            colorOutputcalc(red);
            return red;
        }
        public int calcInputs()
        {
            int inputs = 0;
            string name;

            for (int i = 0; i < dgverdad.ColumnCount; i++)
            {
                name = dgverdad.Columns[i].HeaderText;
                if (name.Contains("X")) inputs += 1;
            }

            return inputs;
        }
        public int calcOutputs()
        {
            int outputs = 0;
            string name;

            for (int i = 0; i < dgverdad.ColumnCount; i++)
            {
                name = dgverdad.Columns[i].HeaderText;
                if (name.Contains("Yesp")) outputs += 1;
            }

            return outputs;
        }

        private void btlimpia_Click(object sender, EventArgs e)
        {
            lbres.Items.Clear();
            tbalpha.Text = "";
            tbcrear.Text = "";
            tbepocas.Text = "";
            tberror.Text = "";
            dgverdad.Columns.Clear();
            dgvcapsocul.Rows.Clear();
        }

        public void Entrada()
        {
            alpha = Convert.ToDouble(tbalpha.Text);
            capas = Convert.ToInt32(tbepocas.Text);
            error = Convert.ToDouble(tberror.Text);
            epocas = Convert.ToInt32(tbepocas.Text);
        }
        public void printDGV()
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
                    generaTabla(2, "xor");
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
                    dgverdad.Rows[j].Cells[cols].Value = 0;
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
                if (j == 1 || j == 2)
                    dgverdad.Rows[j].Cells[2].Value = 1;
                else
                    dgverdad.Rows[j].Cells[2].Value = 0;
            }
            //pintar celdas de la salida
            pintaColum(true);
        }
        public void llenaMayoria()
        {
            int valor, c_ones, c_zeros;
            for (int j = 0; j < rows; j++)
            {
                c_ones = 0; c_zeros = 0;
                for (int i = 0; i < cols; i++)
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
                    dgverdad.Rows[j].Cells[cols].Value = 0;
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
                    dgverdad.Rows[j].Cells[cols].Value = 0;
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
                    dgverdad.Rows[j].Cells[2].Value = 0;
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
