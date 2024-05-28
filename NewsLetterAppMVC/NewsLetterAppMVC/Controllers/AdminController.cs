using NewsLetterAppMVC.Models;
using NewsLetterAppMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsLetterAppMVC.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            //Entity framework which replaces the ADO.NET code commented out at the bottom
            using (NewsLetterEntities db = new NewsLetterEntities())
            {
                //Lambda syntax or LINK
                //var signups = db.SignUps.Where(x => x.Removed ==null).ToList(); // 1)Grab all the signups from the database. This is a property in Newsletter.Context.cs. The property is the list of records in that table
                //OR use LINK (language Integerated query, which reads easier than the above line 
                var signups = (from c in db.SignUps where c.Removed == null select c).ToList();

                var signupVms = new List<SignupVm>(); // 2)create alist of view models
                //Limiting the information passed to the view
                //This is using the ViewModels folder to create the model that will be viewed, so not all properties in the Model has to be passed to the view
                foreach (var signup in signups) // 3)loop through the models and map the view models from the model to view model
                {
                    var signupVm = new SignupVm();
                    signupVm.Id = signup.Id;
                    signupVm.FirstName = signup.FirstName;
                    signupVm.LastName = signup.LastName;
                    signupVm.EmailAddress = signup.EmailAddress;
                    signupVms.Add(signupVm);
                }


                return View(signupVms); // 4) pass viewmodel to the view

            }
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
        public ActionResult Unsubscribe(int Id)
        {
            using (NewsLetterEntities db = new NewsLetterEntities())
            {
                var signup = db.SignUps.Find(Id);//Find only works with Primary key
                signup.Removed = DateTime.Now;
                db.SaveChanges();

            }
            return RedirectToAction("Index");
        }
    }
}