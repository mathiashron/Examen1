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
            ///
            ///Comentario del profesor: si vas a usar una expresión regular para convertir las mayusculas en espacios, tenés que 
            ///explicar como funciona esa expresión regular, sino asumo que solo la copiaste de internet sin entenderla y perdés 50% de la pregunta.
            ///
            ///Lo primero que realizo es separar las fraces que estan en mayusculas
            ///eso le agrega un espacio luego con el split cuentos los espacios y eso me da la cantidad
            ///de palabras
            /// La cadena (?!^) lo que realiza es que omite si la primera esta en mayuscula para no contarla como una 
            ///palabra mas y tambien continua la busqueda en las demas ^.
            /// la cadena [A-Z] busca las letras desde la A hasta la Z en mayuscula si la encuentra entonces la cadena
            /// " $1" le agrega el espacio que esta al inicio del $ y continua.
            /// Mejore el scrip al analizar cada elemento de la exprecion "(((?<!^)[A-Z](?=[a-z]))|((?<=[a-z])[A-Z]))", " $1")
            ///</summary>
            int dato = 0;
            var separar = Regex.Replace(cal, "((?!^)[A-Z])", " $1");
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
