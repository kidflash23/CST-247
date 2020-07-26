using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Activity2Part1.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {

            //This is the first test in testing the HTML Label Helper
            List<Activity2Part1.Models.UserModel> users = new List<Activity2Part1.Models.UserModel>();

            //Here is the data annotation for the username property:
            [Required]
            [DisplayName("User Name")]
            [StringLength(20, MinimumLength = 4)]
            [DefaultValue("")]

            //Here is the data annotation for the password property:
            [Required]
            [DisplayName("Password")]
            [StringLength(20, MinimumLength = 4)]
            [DefaultValue("")]

            //Updated Login Controller for Data Validation:
            // Validate the Form POST
            if (!ModelState.IsValid)
                return View("Login");

            else
                return ("Login Success");


            Activity2Part1.Models.UserModel user = new Models.UserModel("Mike Jones", "mikeymike@gmail.com", "(404) 444-4444");
            Activity2Part1.Models.UserModel user2 = new Models.UserModel("Mary Janefield", "mjf@yahoo.com", "(404) 444-4444");
            Activity2Part1.Models.UserModel user3 = new Models.UserModel("Luke Cage", "brassnuckles@yahoo.com", "(404) 444-4444");
            Activity2Part1.Models.UserModel user4 = new Models.UserModel("Ben Teneson", "omnitrix@yahoo.com", "(404) 444-4444");


            users.Add(user);
            users.Add(user2);
            users.Add(user3);
            users.Add(user4);

            
            return View("Test", users);

        }
    }
}