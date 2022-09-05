using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laberinto
{
    public partial class Form1 : Form
    {
        int[,] matriz = new int[11, 11];
        int nfilas = 11, ncol = 11;
        public Form1()
        {
            InitializeComponent();
        }

        private void btsolucion_Click(object sender, EventArgs e)
        {
            //crear matriz de 1 y 0 para simulacioines
            //int[,] matriz = new int[11, 11];

            lvcolas.Items.Clear();

            int[,] checado = new int[11, 11];

            Random valor = new Random();

            //genera la matriz con ceros

            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    checado[i, j] = 0;
                }
            }

            // aplicacion del algoritmo

            //****************COLA******************

            Queue C = new Queue();
            bool solucion = false;

            C.Enqueue("0,0"); // poner la lista en el inicio del laberinto
            int fila, col;

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

                checado[fila, col] = 1; // 1 es que ya se guradó esa posicion

                if (checado[10, 10]==1)
                {
                    solucion = true;
                    break;
                }

                //paso 2
                if (col < 10 && matriz[fila, col + 1] == 0 && checado[fila, col + 1] != 1) // checa si hay a la derecha
                {
                    fila_str = fila.ToString();
                    col_str = (col + 1).ToString();
                    C.Enqueue(fila_str + "," + col_str); //agrega hijos de la posicion
                    checado[fila, col + 1] = 1;
                }
                if (fila < 10 && matriz[fila + 1, col] == 0 && checado[fila + 1, col] != 1) // checa si hay  abajo
                {
                    fila_str = (fila + 1).ToString();
                    col_str = (col).ToString();
                    C.Enqueue(fila_str + "," + col_str); //agrega hijos de la posicion
                    checado[fila + 1, col] = 1;
                }
                if (col != 0 && matriz[fila, col - 1] == 0 && checado[fila, col - 1] != 1) // checa si hay a la izquierda
                {
                    fila_str = fila.ToString();
                    col_str = (col - 1).ToString();
                    C.Enqueue(fila_str + "," + col_str); //agrega hijos de la posicion
                    checado[fila, col - 1] = 1;
                }
                if (fila != 0 && matriz[fila - 1, col] == 0 && checado[fila - 1, col] != 1) // checa si hay arriba
                {
                    fila_str = (fila - 1).ToString();
                    col_str = (col).ToString();
                    C.Enqueue(fila_str + "," + col_str); //agrega hijos de la posicion
                    checado[fila - 1, col] = 1;
                }

                //C.Dequeue();
                
                lvcolas.Items.Add(C.Dequeue().ToString());


                if (C.Count == 0)
                {
                    MessageBox.Show("No hay solución");
                    break;
                }

                solucion = false;

            }

            if (solucion)
            {
                MessageBox.Show("Solución encontrada");
            }


            //******************PILA******************
            /*
            Stack P = new Stack();
            P.Push("0,0");

            while (!solucion)
            {
                //paso 1
                coordenada = P.Peek().ToString();
                index = coordenada.IndexOf(',');

                fila = int.Parse(coordenada.Substring(0, index));
                col = int.Parse(coordenada.Substring(index + 1));

                checado[fila, col] = 1; // 1 es que ya se guadó esa posicion

                //paso 2
                if (fila == 10 && col == 10)
                {
                    solucion = true;
                    break;
                }

                //paso 3
                lvcolas.Items.Add(P.Pop().ToString());

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

                if (P.Count == 0)
                {
                    MessageBox.Show("No hay solución");
                    break;
                }

                solucion = false;

            }

            if (solucion)
            {
                MessageBox.Show("Solución encontrada");
            }*/
        }

        private void btlaberinto_Click(object sender, EventArgs e)
        {
            Random k;
            k = new Random();
            int aleat, valor;
            Graphics g = pB.CreateGraphics();
            Pen lapiz = new Pen(Color.DarkBlue);
            Size s = new System.Drawing.Size(50, 50);
            //SolidBrush brocha = new SolidBrush(Color.AliceBlue);
            Image pasto = Image.FromFile(@"pasto.bmp");
            //             Bitmap image1 = (Bitmap) Image.FromFile(@"pasto.bmp", true);
            //             TextureBrush pasto = new TextureBrush(image1);
            Image pared = Image.FromFile(@"pared.bmp");

            //             Bitmap image2 = (Bitmap)Image.FromFile(@"pared.bmp", true);
            //            TextureBrush pared = new TextureBrush(image2);
            //             Bitmap image3 = Bitmap(Image.FromFile(@"entrada.bmp", true), s);
            Image entrada = Image.FromFile(@"entrada.bmp");

            //             Bitmap image3 = (Bitmap)Image.FromFile(@"entrada.bmp", true);
            //            TextureBrush entrada = new TextureBrush(image3);

            //TextureBrush textura;
            Image textura;
            Point p = new Point(0, 0);
            Rectangle[,] r;
            r = new Rectangle[nfilas, ncol];
            for (int i = 0; i < nfilas; i++)
            {
                for (int j = 0; j < ncol; j++)
                {
                    if ((i == 0 && j == 0) || (i == nfilas - 1 && j == ncol - 1))
                    {
                        if (i == 0)
                            textura = entrada;
                        else
                            textura = pasto;
                        valor = 0;
                    }
                    else
                    {
                        if (i % 2 == 0 && j % 2 != 0)
                        {
                            textura = pasto;
                            valor = 0;
                        }
                        else
                        {
                            aleat = k.Next(2);
                            if (aleat == 0)
                                textura = pasto;
                            else
                                textura = pared;
                            valor = aleat;
                        }
                    }
                    matriz[i, j] = valor; //Laberinto
                    r[i, j].Location = p;
                    r[i, j].Size = s;
                    //                    g.DrawRectangle(lapiz, r[i, j]);
                    //                    g.FillRectangle(textura, r[i, j]);
                    g.DrawImage(textura, r[i, j]);
                    p.X += 50;
                }

                p.X = 0;
                p.Y += 50;
            }

        }
    }
}
