using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace w2t4
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"/Users/aldiyarturegaliyev/Desktop/PP2/week2/w2t4/Example.txt"; //saving our file path
            string path1 = @"/Users/aldiyarturegaliyev/Desktop/PP2"; //showing the way to directory
            DirectoryInfo dirInfo = new DirectoryInfo(path1); //giving name to file
            FileInfo fi = new FileInfo(path); //giving name to call easily
            if (fi.Exists && dirInfo.Exists) //if these directory and file so do these function
            {
                fi.CopyTo(path1 + @"\Copied.txt", true); //if true create file and delete original
                fi.Delete(); //deleting first original file
            }
            else Console.WriteLine("path or path1 not found:("); //or if its not exist show these sentence" a

        }
    }
}
