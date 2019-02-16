using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine()); //length of massive
            int[] arr = new int[a];
            string[] s = Console.ReadLine().Split(); // saving numbers
            for (int i = 0; i < arr.Length; i++) // cycle
            {
                arr[i] = int.Parse(s[i]); //saving numbers in array and parsing
                Console.Write(arr[i] + " " + arr[i] + " ");//showing in console number by doubling them

            }
            Console.ReadKey();
        }
    }
}
