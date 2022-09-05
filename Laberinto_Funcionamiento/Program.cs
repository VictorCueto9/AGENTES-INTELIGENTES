using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laberinto_Funcionamiento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string c =  "1,2"; //codigo para extraer las coordenadas.
            string i,j;

            int index;
            index = c.IndexOf(',');


            i = c.Substring(0, index);
            j = c.Substring(index+1);

            Console.WriteLine(i+j);*/

            //crear matriz de 1 y 0 para simulacioines
            int[,] matriz = new int[11, 11];
            int[,] checado = new int[11, 11];
            //int sin_sol = 0;

            Random valor = new Random();

            //genera la matriz con ceros y unos aleatorios

            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    if(i == 0 && j==0)
                        matriz[i, j] = 0;
                    else
                        matriz[i, j] = valor.Next(2);
                    checado[i, j] = 0;
                }
            }

            //imrime la matriz con ceros y unos aleatorios

            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    Console.Write(matriz[i, j]);
                }
                Console.WriteLine();
            }

            //imprime la matriz checado con ceros

            Console.WriteLine("Checado: ");

            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    Console.Write(checado[i, j]);
                }
                Console.WriteLine();
            }

            // aplicacion del algoritmo
            /*
            Queue C = new Queue();
            bool solucion = false;

            C.Enqueue("0,0"); // paso  0 poner la lista en el inicio del laberinto
            int fila = 0, col = 0;

            string coordenada;
            string fila_str, col_str;

            int index;


            while (!solucion)
            {
                //paso 1
                coordenada = C.Peek().ToString();
                index = coordenada.IndexOf(',');

                fila = int.Parse(coordenada.Substring(0, index));
                col = int.Parse(coordenada.Substring(index + 1));

                checado[fila, col] = 1; // 1 es que ya se guadó esa posicion

                PrintValues(C);


                //paso 2
                if (col < 10 && matriz[fila, col + 1] == 0 && checado[fila, col + 1] != 1) // checa si hay a la derecha
                {
                    fila_str = fila.ToString();
                    col_str = (col + 1).ToString();
                    C.Enqueue(fila_str + "," + col_str); //agrega hijos de la posicion
                    checado[fila, col+1] = 1;
                    sin_sol += 1;
                }
                if (fila < 10 && matriz[fila + 1, col] == 0 && checado[fila + 1 , col] != 1) // checa si hay  abajo
                {
                    fila_str = (fila + 1).ToString();
                    col_str = (col).ToString();
                    C.Enqueue(fila_str + "," + col_str); //agrega hijos de la posicion
                    checado[fila+1, col] = 1;
                    sin_sol += 1;
                }
                if (col != 0 && matriz[fila, col - 1] == 0 && checado[fila, col - 1] != 1) // checa si hay a la izquierda
                {
                    fila_str = fila.ToString();
                    col_str = (col - 1).ToString();
                    C.Enqueue(fila_str + "," + col_str); //agrega hijos de la posicion
                    checado[fila, col-1] = 1;
                    sin_sol += 1;
                }
                if (fila != 0 && matriz[fila - 1, col] == 0 && checado[fila - 1, col] != 1) // checa si hay arriba
                {
                    fila_str = (fila - 1).ToString();
                    col_str = (col).ToString();
                    C.Enqueue(fila_str + "," + col_str); //agrega hijos de la posicion
                    checado[fila - 1, col] = 1;
                    sin_sol += 1;
                }
                if (checado[10, 10] == 1)
                {
                    solucion = true;
                }
                
                C.Dequeue();
                
                if (sin_sol == 0 || C.Count == 0)
                {
                    Console.WriteLine("No hay solucion");
                    break;
                }

                solucion = false;

            }

            //imprime la matriz checado despues del algoritmo

            Console.WriteLine("Checado: ");

            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    Console.Write(checado[i, j]);
                }
                Console.WriteLine();
            }

            if (solucion)
            {
                Console.WriteLine("Solucion encontrada");
            }*/


            Stack P = new Stack();
            P.Push("0,0");

            int fila = 0, col = 0;

            string coordenada;
            string fila_str, col_str;

            int index;
            bool solucion = false;

            while (!solucion)
            {
                //paso 1
                coordenada = P.Peek().ToString();
                index = coordenada.IndexOf(',');

                fila = int.Parse(coordenada.Substring(0, index));
                col = int.Parse(coordenada.Substring(index + 1));

                checado[fila, col] = 1; // 1 es que ya se guadó esa posicion

                PrintValues(P);

                //paso 2
                if (fila == 10 && col == 10)
                {
                    solucion = true;
                    break;
                }

                //paso 3
                P.Pop();

                //paos 4

                if (col < 10 && matriz[fila, col + 1] == 0 && checado[fila, col + 1] != 1) // checa si hay a la derecha
                {
                    fila_str = fila.ToString();
                    col_str = (col + 1).ToString();
                    P.Push(fila_str + "," + col_str); //agrega hijos de la posicion
                    checado[fila, col + 1] = 1;
                }
                if (fila < 10 && matriz[fila + 1, col] == 0 && checado[fila + 1, col] != 1) // checa si hay  abajo
                {
                    fila_str = (fila + 1).ToString();
                    col_str = (col).ToString();
                    P.Push(fila_str + "," + col_str); //agrega hijos de la posicion
                    checado[fila + 1, col] = 1;
                }
                if (col != 0 && matriz[fila, col - 1] == 0 && checado[fila, col - 1] != 1) // checa si hay a la izquierda
                {
                    fila_str = fila.ToString();
                    col_str = (col - 1).ToString();
                    P.Push(fila_str + "," + col_str); //agrega hijos de la posicion
                    checado[fila, col - 1] = 1;
                }
                if (fila != 0 && matriz[fila - 1, col] == 0 && checado[fila - 1, col] != 1) // checa si hay arriba
                {
                    fila_str = (fila - 1).ToString();
                    col_str = (col).ToString();
                    P.Push(fila_str + "," + col_str); //agrega hijos de la posicion
                    checado[fila - 1, col] = 1;
                }

                if(P.Count == 0)
                {
                    Console.WriteLine("No hay solucion");
                    break;
                }

                solucion = false;

            }

            if (solucion)
            {
                Console.WriteLine("Solucion Encontrada");
            }

            


            Console.ReadLine();
        }
        public static void PrintValues(IEnumerable myCollection)
        {
            foreach (Object obj in myCollection)
                Console.Write("    {0}", obj);
            Console.WriteLine();
        }
    }
}
