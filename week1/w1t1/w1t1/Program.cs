using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace w1t1
{
    class Program
    {
        static void Main(string[] args)
        {
            String s = Console.ReadLine(); //creating string to parse their int
            int n = int.Parse(s); //paring here because it reads only string
            String str = Console.ReadLine(); //creating another string to wirte their our nombers
            String[] st = str.Split(); //here we split because string will read all inputs
            int[] arr = new int[n]; //crearting int array
            List<int> ans = new List<int>(); //creating list for add our prime numbers
            for (int i = 0; i < n; i++) 
            {
                arr[i] = int.Parse(st[i]); //here we parsing nubers from string to int
                bool prime = false; //making bool
                for (int j = 2; j <= Math.Sqrt(arr[i]); j++) //another cycle for count number for prime
                {
                    if (arr[i] % j == 0) //if its true so its not ptime
                    {
                        prime = true;
                    }
                }
                if (!prime && arr[i] != 1) //here prme because of its result
                {
                    ans.Add(arr[i]);
                }
            }
            Console.WriteLine(ans.Count); //amount of prime numbers
            for (int i = 0; i < ans.Count; i++)
            {
                Console.Write(ans[i] + " "); //prime numbers list
            }
            Console.ReadKey();
        }
    }
}
