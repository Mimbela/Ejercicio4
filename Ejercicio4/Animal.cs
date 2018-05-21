using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    public class Animal
    {
        public string Clase { get; set; }
        public string Nombre { get; set; }
        public double Peso { get; set; }
        public int Jaula { get; set; }


        public Animal(string clase, string nombre, double peso, int jaula)
        {
            Clase = clase;
            Nombre = nombre;
            Peso = peso;
            Jaula = jaula;
        }
        /// <summary>
        /// virtual, porque esa clase será sobre escrita en la clase hija
        /// </summary>
        public virtual void ImprimirFicha()
        {
            Console.WriteLine("CLASE ANIMAL: {0}", Clase);
            Console.WriteLine("NOMBRE ANIMAL: {0}", Nombre);
            Console.WriteLine("PESO: {0} kg", Peso);
            Console.WriteLine("JAULA: {0}", Jaula);
        }
    }
}
