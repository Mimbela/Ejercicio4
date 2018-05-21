using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    public class Mamifero : Animal
    {
        public int Edad { get; set; }

        public Mamifero(string clase, string nombre, double peso, int jaula, int edad) : base(clase, nombre, peso, jaula)
        {
            Edad = edad;
        }

        public override void ImprimirFicha()
        {
            Console.WriteLine("CLASE ANIMAL: {0}", Clase);
            Console.WriteLine("NOMBRE ANIMAL: {0}", Nombre);
            Console.WriteLine("PESO: {0} kg", Peso);
            Console.WriteLine("JAULA: {0}", Jaula);
            Console.WriteLine("Edad {0}", Edad);
            Console.WriteLine("Estoy Rugiendo");
        }
    }
}
