using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {

            List  <int> numeros = new List <int> ();
            var diasSemana = new List <string> ();
            numeros.Add(5);
            numeros.Add(6);
            numeros.Add(5);
            numeros.Add(30);
            numeros.Add(50);
            numeros.Add(60);
            diasSemana.Add( "Lunes" );
            diasSemana.Add( "Martes ");
            diasSemana.Add( "Miercoles" );
            diasSemana.Add( "Jueves" );
            diasSemana.Add( "Viernes") ;
            Console.WriteLine("Esta es la lista de los numeros" );
            foreach (var item in numeros)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Estos son los dias de la semana ");
            foreach (var item in diasSemana)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine( "Eliminando a 50 de la lista de numeros" );
            numeros.Remove(50);
            foreach (var item in numeros)
            {
                Console.WriteLine(item);
            }











        }
    }
}
