using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Cons_ChainConstructors
{
    class Program
    {
        static void Main(string[] args)
        {

            const string riverName = "Thame";//Creating a constant

            var riverLength = new Dictionary<string, int>();//Creating a variable

        }

        //example of chained constructors
        public class animals
        {
            public string animalName;
            public int animalLength;

            //Constructor 1
            public animals(string animalName) : this(animalName, 2)
            {

            }

            //Constructor 2
            public animals(string animalName, int animalLength)
            {
                this.animalName = "animalName";
                this.animalLength = 5;
            }
        }
    }
}
