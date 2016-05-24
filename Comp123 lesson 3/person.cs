using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp123_lesson_3
{
    class person
    {
        // private instance variables 
        private string _name;

        // public properties
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
    }
}
