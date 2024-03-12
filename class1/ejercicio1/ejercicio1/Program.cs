/*
Ejercicio 1
Crear un proyecto de consola que genere 1000 instancias la clase Persona, y que luego de crear imprima por consola la Edad
La clase persona que tenga estas propiedades
Nombre
Apellido
Edad (en clases posteriores vamos realizarlo al calculo o el que lo quiere realizar ya con FechaNacimiento)
*/

using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for (int i = 0; i < 10; i++)
            {
                Persona persona = new Persona();
                Console.WriteLine($"Persona N° {i + 1} \n Nombre: {persona.Nombre} /// Edad: {persona.Edad} /// Fecha de Ncimiento: {persona.FechaNacimiento}");
            }

            Console.ReadLine(); 
        }
    }

    class Persona
    {
        private static Random rnd = new Random();

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; }
        public int FechaNacimiento { get; set; }

        public Persona()
        {
            this.Nombre = GenerarNombreAleatorio();
            this.Apellido = GenerarApellidoAleatorio();
            this.Edad = rnd.Next(18, 81);
            this.FechaNacimiento = 2024 - this.Edad;
        }

        private string GenerarNombreAleatorio()
        {
            string[] nombres = { "Juan", "María", "Pedro", "Ana", "Luis", "Sofía", "Carlos", "Laura", "Javier", "Elena" };
            return nombres[rnd.Next(nombres.Length)];
        }

        private string GenerarApellidoAleatorio()
        {
            string[] apellidos = { "García", "Martínez", "Fernández", "López", "González", "Rodríguez", "Pérez", "Sánchez", "Ramírez", "Torres" };
            return apellidos[rnd.Next(apellidos.Length)];
        }
    }
}
