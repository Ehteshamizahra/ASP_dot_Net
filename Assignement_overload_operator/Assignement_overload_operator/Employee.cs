using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement_overload_operator
{
    public class Employee   //Assignment 1, page 315
    //public class Employee<T>  //For assignment 2, page 319
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //public List<T> thing { get; set; } //For assignment 2, page 319

        //Comment back in  the following for Assignment 1, page 315

        //Overload operators to compare employees Ids

        public static Boolean operator ==(Employee employeeID1, Employee employeeID2)
        {
            return employeeID1 == employeeID2;

        }
        public static Boolean operator !=(Employee employeeID1, Employee employeeID2)
        {

                return employeeID1!=employeeID2;
        }
    }
}
