using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace w1t2
{

    class Student //creating class with name student
    {
        public string name; //giving for all these string name
        public string ID;
        public int year;


        public Student(string name, string ID) //creating constructor public student
        {
            this.name = name; //this means to public string name
            this.ID = ID;
        }


        public void Print() //this function shows us students information and adds 1 year 
        {
            Console.WriteLine("Student's name: " + this.name + Environment.NewLine + "Student's ID: " + this.ID + Environment.NewLine + "Student's year of study: " + (this.year + 1));
        }
    }

    class Program
    {

        static void Main(string[] args)
        {

            Student a = new Student("Beketik", "18BD110390"); //writing students information
            a.year = 1;
            a.Print();
            Console.ReadKey();
        }
    }

}
