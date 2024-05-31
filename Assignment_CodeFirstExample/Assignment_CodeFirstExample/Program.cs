using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_CodeFirstExample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StudetContext())
            {
                Console.WriteLine("Enter the student first name:");
                var firstName = Console.ReadLine();
                Console.WriteLine("Enter the student last name:");
                var lastName = Console.ReadLine();

                var student = new Student { FirstName = firstName, LastName = lastName };
                db.Students.Add(student);
                db.SaveChanges();

                var query = from b in db.Students
                            orderby b.LastName
                            select b;

                foreach (var item in query)
                {
                    Console.WriteLine(item.LastName);
                }
            }
        }
    }
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
    }

    public class StudetContext :DbContext
    {
        public DbSet<Student> Students { get; set; } 
    }

}
