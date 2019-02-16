using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace w2t1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("input.txt"); //this inscription opens our file and reads it
            string s = sr.ReadToEnd(); //creating string and reading it till end
            int b = s.Length; 
            int a = 1;
            for (int i = 0; i < b; i++)
            {
                if (s[i] != s[b - i - 1]) //this algorithm counts if our letters equal or not
                {
                    a++;
                }
                if (a == 1)
                {
                    sw.WriteLine("Yes"); //if yes yes write yes
                }
                else
                {
                    Console.WriteLine("No"); //if no write no 
                }
            }
            sr.Close(); //closing our file
            sw.Close(); //closing our output file
            Console.ReadKey();
        }
    }
}
