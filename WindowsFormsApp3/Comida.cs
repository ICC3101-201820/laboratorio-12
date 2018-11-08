using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    [Serializable]
    public class Comida
    {
        string nombre;
        int carbohidratos;
        int proteinas;
        int grasas;

        public Comida(string n, int carbs, int prot, int grasas)
        {
            nombre = n;
            this.grasas = grasas;
            this.carbohidratos = carbs;
            this.proteinas = prot;
        }

        public int Calorias()
        {
            return 4 * carbohidratos + 4 * proteinas + 9 * grasas;
        }

        public override string ToString()
        {

            return $"{nombre} (carbohidratos: {carbohidratos}, proteinas: {proteinas}, grasas: {grasas}, calorias: {Calorias()})";
        }
    }
}
