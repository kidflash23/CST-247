using Activity1Part3.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Activity1Part3.Services.Business.Data {
    public class SecurityDAO {

        public bool FindByUser(UserModel user) {

            // This helps establish the given DB Connection
          
            SqlConnection conn = new SqlConnection(
                "Data Source=(localdb)\\MSSQLLocalDB;" +
                "Initial Catalog=Test;Integrated Security=True;" +
                "Connect Timeout=30;Encrypt=False;" +
                "TrustServerCertificate=True;" +
                "ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            SqlDataReader gmo = null;

            //This is the given SQL syntax
            //in which it gets the Username and Paswword from the db of users
            string queryString = "SELECT * FROM dbo.Users WHERE USERNAME ='"
                + user.Username + "' AND PASSWORD ='" + user.Password+"'";

            bool loginSuccess = false;

            try {
                // Starts the open connection
                conn.Open();

                // This creates the Query Statement
                SqlCommand cmd = new SqlCommand(queryString, conn);

                // This helps the given results be read and written into the console
                gmo = cmd.ExecuteReader();
                while (gmo.Read()) {
                    Console.WriteLine(gmo[0]);
                }

                if (gmo.HasRows) { loginSuccess = true; }

            } finally {

                // This helps close the given reader and stops the current connection.
                if (gmo != null) {
                    gmo.Close();
                }

                if (conn != null) {
                    conn.Close();
                }

            }

            return loginSuccess;
    
            
        }

    }
}