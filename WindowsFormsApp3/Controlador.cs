using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class Controlador
    {
        Form1 form1;
        ListaComida comidas;

        public Controlador(Form1 form1)
        {
            comidas = ListaComida.Deserializar();
            this.form1 = form1;
            this.form1.OnAgregarComida += AgregarComida;
            this.form1.OnEliminarComida += EliminarComida;
            AgregarComidas();
        }

        public void AgregarComida(string nombre, int c, int p, int g)
        {
            Comida comida = new Comida(nombre, c, p, g);
            comidas.AgregarComida(comida);
            ListaComida.Serializar(comidas);
            form1.AgregarComidaAlListBox(comida);
        }

        private void AgregarComidas()
        {
            foreach (Comida comida in comidas.comidas)
                form1.AgregarComidaAlListBox(comida);
        }

        private void EliminarComida(Comida comida)
        {
            comidas.EliminarComida(comida);
            ListaComida.Serializar(comidas);
            form1.EliminarComidaDelListBox(comida);
        }
    }
}
