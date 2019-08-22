using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrácticaConstrustores
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno();

            Console.WriteLine("Alumno 1: ");
            Console.WriteLine("Nombre: " + alumno1.Nombre);
            Console.WriteLine("Matricula: " + alumno1.Matricula);
            Console.WriteLine("Correo: ");
            Console.WriteLine("Direccion: ");

            Alumno alumno2 = new Alumno("Fatima", "fatima@correo.com");

            Console.WriteLine("Alumno 2: ");
            Console.WriteLine("Nombre: " + alumno2.Nombre);
            Console.WriteLine("Matricula: " + alumno2.Matricula);


            Console.Read();
        }
    }
}
