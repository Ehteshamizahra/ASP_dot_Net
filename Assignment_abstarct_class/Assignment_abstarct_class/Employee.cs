using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_abstarct_class
{
    //inherit from the Person class
    public class Employee: Person
    {
        //Implement the SayName() class by overriding the abstarct method
        public override void SayName()
        {
            throw new NotImplementedException();
        }



    }
}
