using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Mamifero Simba = new Mamifero("León", "Simba", 200, 32, 32);
            Mamifero Mufasa = new Mamifero("León", "Mufasa", 223, 33, 43);
            Mamifero Rajah = new Mamifero("Tigre", "Rajah", 185, 28, 29);
            Ave PuchinoPio = new Ave("Aguila", "Puchino Pio", 72, 83);
            Simba.ImprimirFicha();
            Mufasa.ImprimirFicha();
            Rajah.ImprimirFicha();
            PuchinoPio.ImprimirFicha();
            PuchinoPio.Volar();



            Console.Read();
        }
    }

}

//EJERCICIO 4
//Se trata de implementar la gestión de un Zoológico.El sistema tendrá una clase base llamada ANIMAL con las siguientes características:
//Atributos:
//• Clase a la que pertenece : León, Águila, Abeja, etc(String)
//• Nombre del Animal : Simba, Maya, Rintintin, etc. (String)
//• Peso(double)
//• Jaula en la que el animal es asignado(int)
//Métodos:
//• Ingresar en el zoo : Constructor
//• Imprimir ficha(por ejemplo sería ):
//CLASE ANIMAL : León
//NOMBRE ANIMAL : Simba



//PESO : 200 kg,
//JAULA : 32
//Y las siguientes clases que derivarán de la anterior:
//• MAMÍFERO
//Atributo:
//• Edad del mamífero(nt)
//Método:
//• Imprimir ficha añadiendo la nueva propiedad
//• Rugir : mostrará por pantalla ‘Estoy rugiendo’;
//• AVE
//Método
//• Volar: : mostrará por pantalla ‘Estoy volando’;
//Crear un programa que gestione el ingreso de los animales(ingresar dos leones, un tigre y un águila) en el zoológico mostrando la ficha técnica y las acciones que cada uno realice.
