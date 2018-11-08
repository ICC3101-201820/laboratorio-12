using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFormsApp3
{
    [Serializable]
    public class ListaComida
    {
        public List<Comida> comidas;

        public ListaComida()
        {
            comidas = new List<Comida>();
        }

        public void AgregarComida(Comida comida)
        {
            comidas.Add(comida);
        }

        public void EliminarComida(Comida comida)
        {
            comidas.Remove(comida);
        }

        public static void Serializar(ListaComida listaComida)
        {
            FileStream fileStream = new FileStream("comidas", FileMode.OpenOrCreate);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(fileStream, listaComida);
            fileStream.Close();
        }

        public static ListaComida Deserializar()
        {
            if (File.Exists("comidas"))
            {
                FileStream fs = new FileStream("comidas", FileMode.Open);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                object deserializado = binaryFormatter.Deserialize(fs);
                ListaComida listaComida = (ListaComida)deserializado;
                fs.Close();
                return listaComida;
            }
            else
            {
                return new ListaComida();
            }
        }
    }
}
