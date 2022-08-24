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
        string ecu, x;
        public Form1()
        {
            InitializeComponent();
        }

        private void btcalc_Click(object sender, EventArgs e)
        {
            Entrada();
            
        }
        private void Entrada()
        {
            ecu = tBecu.Text;
        }
        private void Proceso()
        {
            
        }
        private void Salida()
        {
            tBx.Text = x;
        }
    }
}
