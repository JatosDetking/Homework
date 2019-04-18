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
            string[] test = {"blue", "white", "white", "white", "white", "white", "white", "white", "white", "white", "white", "white", "white", "white", "white", "white", "white", "white", "white", "white", "white", "white", "white", "white", "white", "red", "white", "red", "red", "blue", "blue", "blue", "red", "red", "red", "red", "red", "blue", "blue", "blue", "red", "red", "red", "blue", "red", "white", "red", "white", "red","red", "red", "white", "red", "blue", "red", "blue" };
            int a = 0;
            int b = test.Length-1;
            int c = 0;
            for (int i = 0; i <b+1; i++)
            {
                c++;
                if (String.Equals(test[a], "red"))
                {
                    a++;
                }
                if (String.Equals(test[b], "white"))
                {
                    b--;
                }
                if (String.Equals(test[i], "white"))
                {
                    string temp = test[i];
                    test[i] = test[b];
                    test[b] = temp;
                    b--;
                }
                if (String.Equals(test[i], "red"))
                {
                        string tempp = test[i];
                        test[i] = test[a];
                        test[a] = tempp;
                        a++;
                }
                if (String.Equals(test[i], "blue"))
                {
                        continue;
                }
            }
            for (int i = 0; i < test.Length; i++)
            {
                Console.WriteLine(test[i]);
            }
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
             Console.ReadLine();
        }
    }
}


