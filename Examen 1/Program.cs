using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_1
{
    class Program
    {

        
        static void Main(string[] args)
        {
            
                DiagonalDifference diagonal = new DiagonalDifference();
                string matriz = "11 2 4 5 | 4 5 6 8 | 10 8 -12 2 | 7 4 8 0";
                int val = diagonal.matriz(matriz);
                Console.WriteLine("El resultado de DiagonalDifference es: {0}", val);
                //Console.Read();

                camelCase camel = new camelCase();
                string dato = "SaveChangesInTheEditor";
                int val1 = camel.calculate(dato);
                Console.WriteLine("La cantidad de palabras camelCase : {0}", val1);
                Console.Read();

            }
           


        }
    }

