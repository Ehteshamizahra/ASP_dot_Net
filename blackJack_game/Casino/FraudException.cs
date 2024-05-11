using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class FraudException: Exception
    {
        //Creating two constructors, one overloading the other,
        //and having them implement the exactle same implimentation that exists
        //for exception
        public FraudException()
            : base() { }
        public FraudException(string message)
            : base(message) { }
    }
}
