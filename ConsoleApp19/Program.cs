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
        static string[] cvetove(string[] inputArray)
        {
            int r=0, b=0, w=0;
            int s = 0;
            string[] temp = new string[inputArray.Length];
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                if (String.Equals(inputArray[i],"red"))
                {
                    r++;
                }
                if (String.Equals(inputArray[i], "blue"))
                {
                    b++;
                }
                if (String.Equals(inputArray[i], "white"))
                {
                    w++;
                }
            }
            while (r != 0)
            {
                temp[s] = "red";
                r--;
                s++;
            } while (b != 0)
            {
                temp[s] = "blue";
                b--;
                s++;
            } while (w != 0)
            {
                temp[s] = "while";
                w--;
                s++;
            }
            Array.Copy(temp, inputArray, inputArray.Length);
            return inputArray;
        }
            static void Main(string[] args)
            {
            string[] test = { "red","blue", "white" ,"red", "white","red","red", "white","red","red", "blue","red" };
            Console.WriteLine(cvetove(test));
            for (int i = 0; i < test.Length; i++)
            {
                Console.WriteLine(test[i]);
            }
            }
        }
    }

