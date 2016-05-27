using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2016_Lesson3
{
    /**
     * This class is the "driver" class for our Program
     * 
     * @class Program
     */
    public class Program
    {
        /**
         * the main method for our driver class Program
         * 
         * @method Main
         * @param {sting[]} args
         */
        public static void Main(string[] args)
        {
            // create a new instance of the Person class
            Person heisgnberg = new Person();
            heisgnberg.Name = "Heisgnberg";
            heisgnberg.Age = 28;
            heisgnberg.SaysHello();
            heisgnberg.ShowAge();

            Console.WriteLine();

            Person einstein = new Person("Einstein");
            einstein.Age = 47;
            einstein.SaysHello();
            einstein.ShowAge();

            Console.WriteLine();

            Person marconi = new Person(30);
            marconi.Name = "Guglielmo Marconi";
            marconi.SaysHello();
            marconi.ShowAge();

            Console.WriteLine();

            Person david = new Person("David", 23);
            david.SaysHello();
            david.ShowAge();


        }
    }

}