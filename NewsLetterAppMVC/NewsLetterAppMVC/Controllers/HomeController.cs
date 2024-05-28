using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NewsLetterAppMVC.Models;
using NewsLetterAppMVC.ViewModels;

namespace NewsLetterAppMVC.Controllers
{
    public class HomeController : Controller
    {
        //No need for connection string as entity frame work does the job
        //private readonly string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=NewsLetter;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost] //anytime you post method include ths tag to notify the coder about the impact of 'posting'
        public ActionResult SignUp(string firstName, string lastName, string emailAddress)
        {

            if (string.IsNullOrEmpty(firstName)|| string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress) )
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                //Entity framework which replaces the ADO.NET code commented out at the bottom
                //We take 3 parameters in firstname,lastname and email, and we are mapping them to a new signup object
                using (NewsLetterEntities db = new NewsLetterEntities())
                {
                    
                    var signup = new SignUp(); //if we have multiple tables each table gets its own properties. This is a property in Newsletter.Context.cs. The property is the list of records in that table
                    //map the properties fro signup object to the input parameters
                    signup.FirstName = firstName;
                    signup.LastName = lastName;
                    signup.EmailAddress = emailAddress;

                    //Add the new object to the database
                    db.SignUps.Add(signup);
                    db.SaveChanges();

                }
                return View("Success");

                ////////////////////////////////////////////////////////////////////////////////////////////////////
                //// ADO.NET which is commented out and replaced by entity framework calls
                //string queryString = @"INSERT INTO SignUps (FirstName, LastName, EmailAddress) VALUES
                //                        (@FirstName, @LastName, @EmailAddress)";

                //using (SqlConnection connection = new SqlConnection(connectionString))
                //{
                //    SqlCommand command = new SqlCommand(queryString, connection);
                //    command.Parameters.Add("@FirstName", SqlDbType.VarChar);
                //    command.Parameters.Add("@LastName", SqlDbType.VarChar);
                //    command.Parameters.Add("@EmailAddress", SqlDbType.VarChar);

                //    command.Parameters["@FirstName"].Value = firstName;
                //    command.Parameters["@LastName"].Value = lastName;
                //    command.Parameters["@EmailAddress"].Value = emailAddress;

                //    connection.Open();
                //    command.ExecuteNonQuery();
                //    connection.Close();

                //}
                //return View("Success");
                ////////////////////////////////////////////////////////////////////////////////////////////////////
            }
        }

    }
    
}