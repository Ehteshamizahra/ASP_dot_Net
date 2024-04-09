using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_abstarct_class
{
    //Create an abstract class with two properties 
    public abstract class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        //Create an abstract method
        public abstract void SayName();


    }
}
