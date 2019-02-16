using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace w1t4

{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //as we know c# writes as string so we imediatly parsig from console
            for(int i=0; i < n; i++)
            {
                for(int j=0; j<i; i++)
                {
                    Console.Write("[*]") //this function shows "[*]a
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
