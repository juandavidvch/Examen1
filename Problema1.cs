using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenI
{
    public class DiagonalDifference
    {
        static void Main(string[] args)
        {
            string input = "28 64 54 | 125 35 12 | 100 25 6";
            DiagonalDifference calc = new DiagonalDifference();
            int res = calc.matrix(input);
            Console.WriteLine("La diferencia de la suma de las diagonales es: {0}", res);
            Console.ReadKey();
        }



        public int matrix(string word ) //metodo de tipo entero que recibe un string
        {
            int count = 0;  //variable que lleva el conteo de numeros para crear la matriz
            int sum1=0, sum2=0, res=0;  //almacenaran las respectivas operaciones de sumas y resta
            int a = 0; //controlara la suma en las filas mientras d se decrementa (suma segunda diagonal)
            int column=0, row=0; //sirven para ejecutar el llenado de la matriz , tipo de guia
            char delimiter1 = ' '; //caracter que sirve como delimitador de espacios
            char delimeter2 = '|'; //caracter que sirve como delimitador de barra vertical
            string [] separated = word.Split(delimiter1); // almacenar las variables separadas por espacios, en un array de caracteres en base a la cadena recibida
            
            foreach (string s in separated) //este foreach sirve para saber la cantidad de elementos a insertar en la matriz
            {
                if (s != "|")   // validar que de los valores que hay en el string array NO sea | , ya que esos serviran para llenar la matriz
                {
                    count++;    
                }
                else
                    break;
            }
            
            int[,] mat = new int[count, count]; //array de tipo int que se inicializa acorde a la cantidad de numeros contados en el string array
            
            foreach (string s in separated) //llenar la matriz de numeros enteros a partir del string array obtenido 
            {
                if (s != "|")   // validar que de los valores que hay en el string array NO sea | , ya que esos serviran para llenar la matriz
                {
                    mat[row, column] = Int16.Parse(s);  //llena matriz de tipo int en posicion row, column con el valor recibido de cada valor de; string array
                    column++;
                }
                else
                {
                    column = 0;
                    row++;
                }
            }

            for (int d = 0; d < count; d++) //sumar diagonal izq-der
                sum1 = sum1 + mat[d, d];

            
            for (int d = count - 1; d >= 0; d--) //sumar diagonal der-izq
            {
                sum2 = sum2 + mat[a, d];
                a++;
            }
            res = sum1 - sum2;
            if (res <= 0)   //la diferencia debe ser positiva, no importa el orden de la resta
                res = res * (-1);   //si es negativo, se pasa a positivo
            return res;
        }
    }   
}