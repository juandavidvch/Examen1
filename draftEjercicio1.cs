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
            string input = "28 64 54|125 35 12|100 25 6";
            DiagonalDifference calc = new DiagonalDifference();
            calc.matrix(input);
        }


        public int matrix(string word ) //metodo de tipo entero que recibe un string
        {
            char delimiter = '|';
           // char delim = ' ';
            int sum1=0 , sum2=0, difference=0;
            string [] separated = word.Split(delimiter);
            for (int i = 0; i < separated.Length; i++ )
            {
                Console.WriteLine(separated[i]);
            }




                //int [,] array;
                //int o;
                //var a = word.Split(ng[] {"|"},StringSplitOptions.RemoveEmptyEntries);
                //foreach (string s in a)
                //{
                //    o = Convert.ToInt16(a);
                //    //for (int i=0, i<a.Length, i++)

                //    {

                //    }

                //}



                difference = sum1 - sum2;
            return difference;
        }
    }   
}