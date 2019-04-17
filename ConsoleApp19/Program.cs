using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Program
    { 
        static void Main(string[] args)
        {
            string[] test = { "red", "blue", "white", "red", "white", "red", "blue", "red", "white", "red", "red", "blue", "red", "blue" };
            int a = 0;
            int b = test.Length-1;
            for (int i = 0; i < b; i++)
            {
                if (String.Equals(test[i], "red"))
                {
                    string tempp = test[i];
                    test[i] = test[a];
                    test[a] = tempp;
                    a++;
                }
                else if (String.Equals(test[i], "white"))
                {
                    string temp = test[i];
                    test[i] = test[b];
                    test[b] = temp;
                    b--;
                }
                else if(String.Equals(test[i], "blue"))
                {
                    continue;
                }
            }
            for (int i = 0; i < test.Length; i++)
            {
                Console.WriteLine(test[i]);
            }
             Console.ReadLine();
        }
    }
}


