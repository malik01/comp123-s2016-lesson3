using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp123_lesson_3
{
    class Program
    {
        /** 
         * main method with person class
         * @mathod main
         * @param (string[]) args
         */ 
        static void Main(string[] args)
        {
            // create a new instance of person class
            Person person = new Person();
            Console.WriteLine(person.Name);
            // set a value in the Name property of the Person Class
            person.Name = "Tom";
            // get the Name value and print to console
            Console.WriteLine(person.Name);
            Person person0 = new Person("tommy");
            
        }
    }
}
