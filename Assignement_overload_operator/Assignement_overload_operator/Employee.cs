using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement_overload_operator
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Overload operators to compare employees Ids

        public static Boolean operator== (Employee employee, int Id)
        {
              return true;


        }

        public static Boolean operator!= (Employee employee, int Id)
        {

              return false;

        }

    }
}
