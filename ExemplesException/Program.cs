﻿using System;
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

            // Exemple 1
            try
            {
                Console.Write("Donnez un nombre : ");
                string nombre = Console.ReadLine();
                i = int.Parse(nombre);
                int j = 10;
                i = j / i;

                Console.WriteLine(i);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(String.Format("il y un erreur : {0}  ", e.Message));
                
            }
            catch (FormatException e)
            {
                Console.WriteLine("Il y a une erreur dans la saisie du nombre, veuillez entrer un nombre valide");

                Console.WriteLine(String.Format("il y un erreur : {0}  ", e.Message));
                i = 10;
            }
            finally
            {
                Console.WriteLine("Fin de programme");
            }


            // Exemple 2


            // Console.WriteLine(" i = " + i);

            Console.Read();
        }
    }
}
