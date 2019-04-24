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
             string[] test = {"white", "white", "white", "white", "blue","blue", "white", "red", "white", "blue", "white", "white", "white" };
               int a = 0;
               int b = test.Length-1;
               int c = 0;
               for (int i = 0; i < b;i++)
               { 
                   c++;

                if (String.Equals(test[i], "white"))
                {
                    string temp = test[i];
                    test[i] = test[b];
                    test[b] = temp;
                    b--;
                    if (i > 0)
                    {
                        i--;
                    }
                    if (String.Equals(test[i], "red"))
                {
                    string tempp = test[i];
                    test[i] = test[a];
                    test[a] = tempp;
                    a++;
                    if(i>0)
                    {
                    i--;
                    }
                }


                }


               }
               for (int i = 0; i < test.Length; i++)
               {
                   Console.WriteLine(test[i]);
               }
;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.ReadLine();
        }
    }
}


