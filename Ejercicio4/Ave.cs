using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    public class Ave : Animal
    {
        public Ave(string clase, string nombre, double peso, int jaula) : base(clase, nombre, peso, jaula)
        {

        }

        public void Volar()
        {
            Console.WriteLine("Estoy Volando");
        }
    }
}
