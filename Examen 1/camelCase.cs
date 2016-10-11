using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Examen_1
{
    public class camelCase
    {
        public int calculate(string cal)
        {
            ///<summary>
            ///Lo primero que realizo es separar las fraces que estan en mayusculas
            ///eso le agrega un espacio luego con el split cuentos los espacios y eso me da la cantidad
            ///de palabras
            ///</summary>
            int dato = 0;
            var separar = Regex.Replace(cal, "(((?<!^)[A-Z](?=[a-z]))|((?<=[a-z])[A-Z]))", " $1");
            //Console.WriteLine(output);
            string[] lines = separar.Split(' ');
            foreach (string line in lines)
            {
                dato++;

            }

            return dato;
        }

    }
}
