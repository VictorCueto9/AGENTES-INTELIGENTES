using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perceptron_Backpropagation
{
    public class Capa
    {
        public int neuronas { get; set; } //para acceder mas rapido al tamano del vector Umbral, neuronas = Umbral[index].Length
        public double[] Umbral { get; set; }

    }
    public class Peso
    {
        public double[,] W { get; set; }

    }
    public class Red
    {
        public int inputs { get; set; } //solo para pintar las salidas
        public int outputs { get; set; } //solo para pintar las salidas
        public int capa { get; set; } //numero de capas
        public List<Capa> listCapas { get; set; }
        public List<Peso> listPesos { get; set; }
        public List<double[]> listActive { get; set; }
        public List<double[]> listActiveCopy { get; set; }
        public List<double[]> listDeltas { get; set; }

        public Red() //constructor
        {
            listCapas = new List<Capa>();
            listPesos = new List<Peso>();
            listActive = new List<double[]>();
            listDeltas = new List<double[]>();
        }
        public void insertInput(double[] ints) //metodo para agregar entradas diferentes
        {
            listCapas.Insert(0, new Capa() { neuronas = ints.Length, Umbral = ints }); //capa 0
        }
        public void deleteInput() //borra las entradas que se almacenan en listCapas (indice 0) para recibir nuevos valores
        {
            listCapas.RemoveAt(0);
        }
        public void createUmbral(int[] numNeuro) //parametro = numero de neuronas por cada capa,su tamano debe ser del numero de capas - 1. Inclute a la capa de salida
        {
            for (int i = 0; i < capa - 1; i++)
            {
                listCapas.Add(new Capa() { neuronas = numNeuro[i], Umbral = new double[numNeuro[i]] });//crea una lista de capas con umbrales del tamano del no. de neuronas en esa capa
            }
        }
        public void addUmbral(int no_neuronas)
        {
            listCapas.Add(new Capa() { neuronas = no_neuronas, Umbral = new double[no_neuronas] });
        }
        public void fillUmbral()
        {
            Random aleat = new Random();
            for (int i = 0; i < listCapas.Count; i++)
            {
                for(int j = 0; j < listCapas[i].neuronas; j++)
                    listCapas[i].Umbral[j] = aleat.NextDouble();
                //listCapas[i].Umbral[j] = Math.Round(aleat.NextDouble(), 2);
            }

        }
        public void fillUmbral(double[] valuesUmbral, int capa) //parametro vector con los valores de cada umbral y en que capa
        {
            listCapas[capa].Umbral = valuesUmbral;
        }
        public void fillUmbral(double u, int capa) //llena los vectores de los umbrales de una capa con un valor establecido
        {
            for (int j = 0; j < listCapas[capa].neuronas; j++)
                listCapas[capa].Umbral.SetValue(u, j);  //establece valor para cada vector
        }
        public void createPesos() //crea la lista con las matrices de Pesos
        {
            for (int i = 0; i < listCapas.Count - 1; i++)
            {
                listPesos.Add(new Peso() { W = new double[listCapas[i].neuronas, listCapas[i + 1].neuronas] });
            }
        }
        public void fillPesos()
        {
            Random aleat = new Random();
            for (int i = 0; i < listPesos.Count; i++)
            {
                for (int j = 0; j < listPesos[i].W.GetUpperBound(0) + 1; j++) //filas
                {
                    for (int k = 0; k < listPesos[i].W.GetUpperBound(1) + 1; k++) //columnas
                    {
                        listPesos[i].W.SetValue(aleat.NextDouble(), j, k);
                        //listPesos[i].W.SetValue(Math.Round(aleat.NextDouble(), 2), j, k);
                    }
                }
            }

        }
        public void fillPesos(double w, int capa) //llena todos los pesos de un solo valor para cada cada correspondiente
        {
            for (int i = 0; i < listPesos[capa].W.GetUpperBound(0) + 1; i++) //filas
            {
                for (int j = 0; j < listPesos[capa].W.GetUpperBound(1) + 1; j++) //columnas
                {
                    listPesos[capa].W.SetValue(w, i, j);
                }
            }
        }
        public void fillPesos(double[,] w, int capa) //llena los pesos recibiendo una matriz
        {
            listPesos[capa].W = w;
        }
        public void activaNeurona(int capa, string funcion)
        {
            double[] active = new double[listCapas[capa].neuronas];
            int aux = 0; double sum = 0;

            for (int j = 0; j < listCapas[capa].neuronas; j++)
            {
                for (int i = 0; i < listCapas[capa - 1].neuronas; i++)
                {
                    sum += capa == 1 ? listCapas[capa - 1].Umbral[i] * listPesos[capa - 1].W[i, j] : listActive[capa - 2][i] * listPesos[capa - 1].W[i, j];
                }
                sum += listCapas[capa].Umbral[aux];
                sum = funcion == "sigmoide" ? Sigmoide(sum) : Math.Tanh(sum);
                active[aux] = sum;
                sum = 0; aux++;
            }

            listActive.Add(active); //los vectores con la activacion de cada neurona se almacenan en una lista
        }
        private double Sigmoide(double x)
        {
            return 1 / (1 + Math.Exp(-x));
        }
    }

}
