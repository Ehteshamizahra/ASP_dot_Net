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
        private readonly string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=NewsLetter;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

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

        public ActionResult Admin()
        {
            //Entity framework which replaces the ADO.NET code commented out at the bottom
            using (NewsLetterEntities db = new NewsLetterEntities())
            {
                
                var signups = db.SignUps; //if we have multiple tables each table gets its own properties. This is a property in Newsletter.Context.cs. The property is the list of records in that table
                
                
                var signupVms = new List<SignupVm>(); // create a new list of view models
                //Limiting the information passed to the view
                //This is using the ViewModels folder to create the model that will be viewed, so not all properties in the Model has to be passed to the view
                foreach (var signup in signups) // map the view models from the model to view model
                {
                    var signupVm = new SignupVm();
                    signupVm.FirstName = signup.FirstName;
                    signupVm.LastName = signup.LastName;
                    signupVm.EmailAddress = signup.EmailAddress;
                    signupVms.Add(signupVm);
                }


                return View(signupVms); //pass viewmodel to the view

            }


            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //// ADO.NET which is commented out and replaced by entity framework calls
            //string querystring = @"SELECT Id, FirstName, LastName, EmailAddress, SocialSecurityNumber from SignUps";
            //List<NewsletterSignUp> signups = new List<NewsletterSignUp>();

            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{

            //    SqlCommand command = new SqlCommand(querystring, connection);
            //    connection.Open();

            //    SqlDataReader reader = command.ExecuteReader();

            //    while (reader.Read())
            //    {
            //        var signup = new NewsletterSignUp();
            //        signup.Id = Convert.ToInt32(reader["Id"]);
            //        signup.FirstName = reader["FirstName"].ToString();
            //        signup.LastName = reader["LastName"].ToString();
            //        signup.EmailAddress = reader["EmailAddress"].ToString();
            //        signup.SocialSecurityNumber = reader["SocialSecurityNumber"].ToString();
            //        signups.Add(signup);
            //    }

            //}
            //var signupVms = new List<SignupVm>(); // create a new list of view models
            ////Limiting the information passed to the view
            ////This is using the ViewModels folder to create the model that will be viewed, so not all properties in the Model has to be passed to the view
            //foreach (var signup in signups) // map the view models from the model to view model
            //{
            //    var signupVm = new SignupVm();
            //    signupVm.FirstName = signup.FirstName;
            //    signupVm.LastName = signup.LastName;
            //    signupVm.EmailAddress = signup.EmailAddress;
            //    signupVms.Add(signupVm);
            //}


            //return View(signupVms); //pass viewmodel to the view
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }
    }
    
}