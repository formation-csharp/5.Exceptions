using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemplesException
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            //// Exception
            //i = Convert.ToInt32(Console.ReadLine());




            try
            {
                Console.WriteLine("Donnez un nombre : ");
                string nombre = Console.ReadLine();
                i = int.Parse(nombre);
                int j = 0;
                i = i / j;
                // Console.WriteLine("Fin de traitement");
            }

            catch (FormatException e)
            {
                // Console.WriteLine("Il y a une erreur dans la saisie du nombre, veuillez entrer un nombre valide");

                // Console.WriteLine(String.Format("il y un erreur : {0}  ", e.Message));
                i = 10;
            }
            //catch (Exception e)
            //{
            //    //Console.WriteLine("Il y a une erreur dans la saisie du nombre, veuillez entrer un nombre valide");
            //    //Console.WriteLine(String.Format("il y un erreur : {0}  ", e.Message));
            //}
            //catch (DivideByZeroException e)
            //{
            //    Console.WriteLine(String.Format("il y un erreur : {0}  ", e.Message));
            //    i = 2;
            //}
            //catch (NullReferenceException exception)
            //{
            //    Console.WriteLine( String.Format( "il y un erreur : {0}  ", exception.Message));
            //     i = 10; 
            //}

            //finally
            //{
            //    Console.WriteLine("Fin traitement");
            //}



            Console.WriteLine(" i = " + i);

            Console.Read();
        }
    }
}
