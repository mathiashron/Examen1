using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Examen_1
{
    public class DiagonalDifference
    {
        
        public int matriz(string ma)
        {
            ///<summary>
            ///En el siguiente foreach que encontre en internet lo que realizo es quitar los espacios
            ///contar los numeros que hay hasta el | y salir del foreach
            ///relleno la una vareable dato con la cantidad de numeros contados para poder crear
            ///la matrix
            ///</summary>
            int dato = 0;
            string[] lines = ma.Split(' ');
           foreach (string line in lines)
            {
                //Console.WriteLine(line);
                if(line != "|")
                {
                    dato++;
                }
                else
                {
                    break;
                }
                
            }
            ///<summary>
            ///En esta parte creo la matriz con los datos obtenidos y nuevamente con un foreach
            ///quitando los espacios voy asignando los datos en la matrix y pasandolos a enteros
            ///</summary>
            int[,] matriz = new int[dato, dato];
            int fila = 0;
            int columna = 0;
            string[] lines2 = ma.Split(' ');
            foreach (string line in lines2)
            {
                //Console.WriteLine(line);
                if (line != "|")
                {
                    matriz[fila, columna] = Int32.Parse(line);
                    columna++;
                   // Console.WriteLine(line);
                }
                else
                {
                    columna = 0;
                    fila++;

                }

            }
            ///<summary>
            ///una vez que tengo la matrix con la informacion realizo las dos sumas diagonales
            ///
            ///</summary>
            int suma1 = 0;
            int suma2 = 0;
            for (int x = 0; x < dato; x++)
            {
                
                    suma1 = suma1 + matriz[x, x];

                //Console.WriteLine(matriz[x,x]);

            }
            int cont = 0;
            for (int x = dato-1; x >=0 ; x--)
            {
                
                suma2 = suma2 + matriz[cont, x];
                //Console.WriteLine(matriz[cont, x]);
                cont++;
            }
            ///<summary>
            ///resto las dos diagonales y envio el resultado
            ///</summary>
            int resultado = suma1 - suma2;
           // Console.WriteLine(suma1);
           // Console.WriteLine(suma2);
            return resultado;
        }
        

    }
}
