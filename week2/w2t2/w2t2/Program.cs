using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace w2t2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("input.txt"); //incription reads our numbers and saves it in sr 
            string[] s = sr.ReadToEnd.split(); //it saves in string s and splits it
            List<int> ans = new List<int>(); //creating list for adding prime numbers
            int n = s.Count();
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(s[i]); //parsing and saving in a[i]
                bool swt = true; //bool for true false 
                for (j = 2; j < Math.Sqrt(a[i]); j++) //algorithm for finding prime number
                {
                    if (a[i] % j == 0)
                    {
                        swt = true;
                    }
                    if (swt != true)
                    {
                        ans.add(a[i]);
                    }

                }
            }
            StreamWriter sw = new StreamWriter("output.txt"); //our prime numbers copies into output file
            for (int i = 0; i < ans.Count(); i++)
            {
                sw.Write(ans[i] + " "); //this incription we can see in our console
            }
            sr.Close(); //close file
            sw.Close(); //close file
            Console.ReadKey();
        }
    }
}
