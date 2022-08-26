using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract_Process
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string x, izq, der;
            int index, suma_x = 0, suma_ind = 0, suma_x_der = 0, suma_ind_der = 0;

            x = Console.ReadLine();

            index = x.IndexOf("=");

            izq = x.Substring(0, index);
            der = x.Substring(index + 1);

            izq = izq + "a";

            for (int i = 0; i < izq.Length; i++)
            {
                if (x[i] == '+')
                {
                    if (x[i + 2] == 'x')
                    {
                        suma_x += int.Parse(izq[i + 1].ToString());
                    }
                    else
                    {
                        suma_ind += int.Parse(izq[i + 1].ToString());
                    }
                }
                if (x[i] == '-')
                {
                    if (x[i + 2] == 'x')
                    {
                        suma_x += -int.Parse(izq[i + 1].ToString());
                    }
                    else
                    {
                        suma_ind += -int.Parse(izq[i + 1].ToString());
                    }
                }
            }

            der = der + "a";

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

            Console.WriteLine("suma x : {0}", suma_x);
            Console.WriteLine("suma ind : {0}", suma_ind);

            Console.WriteLine("suma x : {0}", suma_x_der);
            Console.WriteLine("suma ind : {0}", suma_ind_der);

            double resultado;
            int x_total = 0, inde_total = 0;

            x_total = suma_x - suma_x_der;
            inde_total = suma_ind_der - suma_ind;

            resultado = (double)inde_total / (double)x_total;

            Console.WriteLine("Resultado {0}", resultado);
            Console.WriteLine(izq);

            Console.ReadLine();
        }
    }
}
