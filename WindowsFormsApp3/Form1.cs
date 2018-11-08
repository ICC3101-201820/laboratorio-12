using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public delegate void AgregarComidaDelegate(string nombre, int c, int p, int g);
    public delegate void EliminarComidaDelegate(Comida comida);

    public partial class Form1 : Form
    {
        public event AgregarComidaDelegate OnAgregarComida;
        public event EliminarComidaDelegate OnEliminarComida;

        public Form1()
        {
            InitializeComponent();
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            string nombre = nombreText.Text;
            int c = (int)carbohidratosNum.Value;
            int p = (int)proteinasNum.Value;
            int g = (int)grasasNum.Value;
            if (OnAgregarComida != null)
            {
                OnAgregarComida.Invoke(nombre, c, p, g);
            }
        }

        public void AgregarComidaAlListBox(Comida comida)
        {
            listadoComidas.Items.Add(comida);
        }

        public void EliminarComidaDelListBox(Comida comida)
        {
            listadoComidas.Items.Remove(comida);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void eliminarButton_Click(object sender, EventArgs e)
        {
            if (listadoComidas.SelectedItem != null)
            {
                Comida comida = (Comida)listadoComidas.SelectedItem;
                if (OnEliminarComida != null)
                {
                    OnEliminarComida.Invoke(comida);
                }
            }
        }

     
    }
}
