using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenI
{
    class CamelCase
    {
        static void Main(string[] args)
        {
            string word = "thisIsAWordToRevealHowManyWordsHasInIt"; //cadena que almacena el texto a descifrar
            CamelCase calc = new CamelCase(); //instanciar clase
            Console.Write("Quantity of words: {0} ", calc.calculate(word)); //imprime el resultado que retorne el metodo
            Console.ReadKey(); //para ver que resultado se ve en pantalla
        }


        public int calculate(string camelCase) //metodo de tipo entero que recibe un string
        {
            int quantity=1; //contador de palabras, por default SIEMPRE HABRA UNA PALABRA
            foreach (char c in camelCase) //evaluar cada caracter del string recibido
            {
                if (Char.IsUpper(c)) //evalua en cada caracter, SI ES MAYUSCULA
                    quantity++; //al encontrar mayuscula, aumenta en 1 la cantidad de palabras, cada mayuscula que vea es una palabra
            }
            return quantity; //regresa la cantidad de palabras contadas
        }
    }   
}