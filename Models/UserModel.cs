using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Activity2Part1.Models
{

    //This first starts creating the User Model Class.
    public class UserModel
    {
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }

        public UserModel(string name, string emailAddress, string phoneNumber)
        {
      //Here are the three properties of the UserModel
      //class

            this.Name = name;
            this.EmailAddress = emailAddress;
            this.PhoneNumber = phoneNumber;
        }



    }
}