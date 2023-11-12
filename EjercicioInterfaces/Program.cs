using System;
using static EjercicioInterfaces.Interface1;

namespace EjercicioInterfaces
{
    class Program
    {
        static void Main()
        {
            // Crear instancias de las clases que implementan la interfaz
            ClaseA objetoA = new ClaseA();
            ClaseB objetoB = new ClaseB();

            // Mostrar datos de la ClaseA
            Console.WriteLine("Datos de la Clase A:");
            MostrarDatos(objetoA);

            // Mostrar datos de la ClaseB
            Console.WriteLine("\nDatos de la Clase B:");
            MostrarDatos(objetoB);
        }

      

        static void MostrarDatos(Interface1 objeto)
        {
            // Utilizar los métodos de la interfaz para mostrar datos
            Console.WriteLine($"Método 1: {objeto.Metodo1()}");
            Console.WriteLine($"Método 2: {objeto.Metodo2()}");
            Console.WriteLine($"Método 3: {objeto.Metodo3()}");
        }
    }
}
