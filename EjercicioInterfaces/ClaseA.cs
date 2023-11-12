using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EjercicioInterfaces.Interface1;

namespace EjercicioInterfaces
{
    internal class ClaseA : Interface1
    {

        // Atributos de la ClaseA
        private string atributo1 = "Atributo ClaseA-1";
        private int atributo2 = 10;
        private string atributo3 = "esto es el metodo claseA";

        // Implementar los métodos de la interfaz
        public string Metodo1()
        {
            return $"ClaseA: {atributo1}";
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
