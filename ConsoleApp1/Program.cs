using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder array = new StringBuilder(Console.ReadLine());
            int[] nos = flattenArray(array);

            Console.WriteLine(nos);            
            Console.ReadLine();
        }

        private static int[] flattenArray(StringBuilder array)
        {
            for (int i = 0; i < array.Length ; i++)
            {
                if ((array.ToString().ToArray()[i].Equals('[') || (array.ToString().ToArray()[i].Equals(']'))))
                {
                    array.Remove(i, 1);
                    i--;
                }
            }
            string[] nos = array.ToString().Split(',');

            return  Array.ConvertAll<string, int>(nos, int.Parse);
        }
    }
}
