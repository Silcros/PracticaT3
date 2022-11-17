using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaT3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textoTelegrama;
            double coste = ' ';

            textoTelegrama = txtTelegrama.Text;
            String[] palabras = textoTelegrama.Split(' ');
            int numPalabras = palabras.Length;

            if (rbUrgente.Checked == true) 
                if (numPalabras <= 10)
                    coste = 5;
                else
                    coste = 5 + 0.75 * (numPalabras - 10);

            if (rbOrdinario.Checked == true)
                if (numPalabras <= 10)
                coste = 2.5;
                else
                coste = 2.5 + 0.5 * (numPalabras - 10);


            txtPrecio.Text = coste.ToString() + " euros";
        }
    }
}
        
        