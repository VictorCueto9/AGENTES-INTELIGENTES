using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1
{
    public partial class Form1 : Form
    {
        string x, izq, der;
        int index, suma_x, suma_ind, suma_x_der, suma_ind_der;
        double resultado;
        int x_total = 0, inde_total = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btborrar_Click(object sender, EventArgs e)
        {
            tBecu.Clear();
            tBx.Clear();
        }

        private void btcalc_Click(object sender, EventArgs e)
        {
            Entrada();
            Proceso();
            Salida();
            
        }
        private void Entrada()
        {
            x = tBecu.Text;
        }
        private void Proceso()
        {
            Inicializar();

            index = x.IndexOf("=");

            izq = x.Substring(0, index);
            der = x.Substring(index + 1);

            izq = Agregar_mas(izq);
            der = Agregar_mas(der);

            izq = Agregar_Unos(izq);
            der = Agregar_Unos(der);


            izq += "a";
            der += "a";

            
            for (int i = 0; i < izq.Length; i++)
            {
                if (izq[i] == '+')
                {
                    if (izq[i + 2] == 'x')
                    {
                        suma_x += int.Parse(izq[i + 1].ToString());
                    }
                    else
                    {
                        suma_ind += int.Parse(izq[i + 1].ToString());
                    }
                }
                if (izq[i] == '-')
                {
                    if (izq[i + 2] == 'x')
                    {
                        suma_x += -int.Parse(izq[i + 1].ToString());
                    }
                    else
                    {
                        suma_ind += -int.Parse(izq[i + 1].ToString());
                    }
                }
            }

            for (int i = 0; i < der.Length; i++)
            {
                if (der[i] == '+')
                {
                    if (der[i + 2] == 'x')
                    {
                        suma_x_der += int.Parse(der[i + 1].ToString());
                    }
                    else
                    {
                        suma_ind_der += int.Parse(der[i + 1].ToString());
                    }
                }
                if (der[i] == '-')
                {
                    if (der[i + 2] == 'x')
                    {
                        suma_x_der += -int.Parse(der[i + 1].ToString());
                    }
                    else
                    {
                        suma_ind_der += -int.Parse(der[i + 1].ToString());
                    }
                }
            }

            x_total = suma_x - suma_x_der;
            inde_total = suma_ind_der - suma_ind;

            resultado = (double)inde_total / (double)x_total;
        }
        private void Salida()
        {
            tBx.Text = resultado.ToString();

        }
        private string Agregar_Unos( string lado)
        {
            char[] simbols = new char[] { '+', '-' };

            for (int i = 1; i <lado.Length; i++)
            {
                for (int sim = 0; sim < 2; sim++)
                {
                    if (lado[i] == 'x' && lado[i - 1] == simbols[sim])
                    {
                        lado = lado.Insert(i, "1");
                        i += 1;
                    }
                }
            }
            return lado;
        }
        private string Agregar_mas(string lado)
        {
            char[] simbols = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};
            
            if (lado[0] == 'x')
            {
                lado = lado.Insert(0,"+");
            }
            else
            {
                foreach (var num in simbols)
                {
                    if (lado[0] == num)
                    {
                       lado = lado.Insert(0, "+");
                    }
                }
            }

            return lado;
        }
        private void Inicializar()
        {
            suma_x = 0;
            suma_ind = 0;
            suma_x_der = 0;
            suma_ind_der = 0;
        }

    }
}
