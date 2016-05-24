using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp123_lesson_3
{
    /**
     * this calss defines a generic person
     * @class person
     * @field _name {string}
     */
      
    class Person
    {
        // private instance variables 
        private string _name;

        // public properties
        /**
         * this is a property for our_name field
         * 
         * @proeprty {string} Name
         */ 
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        /**
         * this is the default empty constructor for the person class
         * @constructor person 
         */
        public Person()
        {
            this._name = "unknown name";
        }
        /**
        * this is the default empty constructor for the person class
        * @constructor person 
        */
        public Person(string name)
        {
            this._name = name;
        }
        
   
    }
}
