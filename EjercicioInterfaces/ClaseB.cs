using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces
{
    internal class ClaseB : Interface1
    {
        // Atributos de la ClaseB
        private string atributo1 = "Atributo ClaseB-1";
        private int atributo2 = 20;
        private string atributo3 = "esto es el metodo claseB";

        // Implementar los métodos de la interfaz
        public string Metodo1()
        {
            return $"ClaseB: {atributo1}";
        }

        public int Metodo2()
        {
            return atributo2;
        }

        public string Metodo3()
        {
            return $"ClaseA: {atributo3}";
        }

    }
}
