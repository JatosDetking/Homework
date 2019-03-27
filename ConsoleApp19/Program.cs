using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
//стр.106 зад.5
{
    class Program
    {
        static string[] ISort(string[] inputArray)
        {
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    int a = -1, b = -1;
                    if (String.Equals(inputArray[j - 1], "red"))
                        a = 0;
                    if (String.Equals(inputArray[j - 1], "blue"))
                        a = 1;
                    if (String.Equals(inputArray[j - 1], "white"))
                        a = 2;
                    if (String.Equals(inputArray[j], "red"))
                       b = 0;
                    if (String.Equals(inputArray[j], "blue"))
                        b = 1;
                    if (String.Equals(inputArray[j], "white"))
                        b = 2;
                    if (a > b)
                    {
                        string temp = inputArray[j - 1];
                        inputArray[j - 1] = inputArray[j];
                        inputArray[j] = temp;
                    }
                }
                
            }
            return inputArray;
        }
            static void Main(string[] args)
            {
            string[] test = { "red","blue", "white" ,"red", "white","red","red", "white","red","red", "blue","red" };
            Console.WriteLine(ISort(test));
            for (int i = 0; i < test.Length; i++)
            {
                Console.WriteLine(test[i]);
            }
            }
        }
    }

