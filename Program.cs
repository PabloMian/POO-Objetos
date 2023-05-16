using Objetos.Clases;
using System;

namespace Objetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Persona persona = new Persona();

            persona.Nombre = "Erling";
            persona.Apellido = "Haaland";
            persona.Edad = 21;
            persona.Salario = 200000000000;

            persona.ImprimirDatos();

            Console.WriteLine("--------------------------------------------------");
            Persona persona2 = new Persona();

            persona2.Nombre = "Kevin";
            persona2.Apellido = "De Bruyne";
            persona2.Edad = 25;
            persona2.Salario = 500000000000;

            persona2.ImprimirDatos();
        }
    }
}
