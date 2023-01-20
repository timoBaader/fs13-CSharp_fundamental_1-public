using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Challenge 1 */
            string text = "this is a text";
            string newText = toTitleCase(text);
            Console.WriteLine(newText); // expect to see "This Is A Text"
            Debug.WriteLine(newText);

            /* Challenge 2 */
            int[,] arrayA = { { 3, 5, 4, 6 }, { 3, 7, 8, 3 } };
            int[,] arrayB = { { 5, 1 }, { 8, 4 }, { 2, 9 }, { 2, 3 } };
            int[,] result = matrixMultiply(arrayA, arrayB);
            Console.WriteLine(result); //share your findings to Slack
            Debug.WriteLine(result);
        }
        static string toTitleCase(string input)
        {
            string result = "";
            string[] str = input.Split(' ');
            foreach(string subStr in str)
            {
                result += char.ToUpper(subStr[0]) + subStr.Substring(1) + " ";
                
            }
            return result;
        }
        static int[,] matrixMultiply(int[,] array1, int[,] array2)
        {
            int[,] result = new int[array1.GetLength(0), array2.GetLength(1)];

            // Twice
            for (int y = 0; y < array1.GetLength(0); y++)
            {
                // twice
                for (int z = 0; z < array1.GetLength(1); z++)
                {
                    //4 times
                    for (int x = 0; x < array2.GetLength(1); x++)
                    {
                        result[y,x] += array1[y, z] * array2[z,x];
                    }                    
                }
                
            } 
            return result;
        }
    }
}
