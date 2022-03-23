using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Prueba_fork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int kTAM = 10;

        // Declaramos y damos tamaño al vector.
        int[] vectorA = new int[kTAM];

        void leerVector(int[] vector)
        {
            int i;

            // Leemos todos los elementos del vector.
            for (i = 0; i < vector.Length; i++)
                vector[i] = int.Parse(Interaction.InputBox("Introduzca el elemento: " + i));
        }

        string mostrarVector(int[] vector)
        {
            string texto;
            int i;

            texto = "Elementos del vector: \n";
            for (i = 0; i < vector.Length; i++)
                texto = texto + vector[i] + ", ";

            return texto;
        }

        // Función que devuelve la media de los elementos del vector
        double mediaVector(int[] vector)
        {
            double suma;

            suma = 0;
            for (int i = 0; i < vector.Length; i++)
                suma = suma + vector[i];

            suma = suma / vector.Length;

            return suma;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texto;

            texto = Interaction.InputBox("introduce tu nombre:...");

            MessageBox.Show(texto);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            leerVector(vectorA);
        }
    }
}
