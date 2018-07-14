using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using CourseScheduler.Models;

namespace CourseScheduler.Databases
{
    public class UserDatabase
    {
        public User AthenicateUser(string userName, string password)
        {
            Database database = new Database();
            SqlConnection sqlConnection = database.Connect();

            string query = "Select * from Users where exists (select * from users where users_username=@userName AND users_password = @password)";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            User user = new User();
            cmd.Parameters.AddWithValue("@userName", userName);
            cmd.Parameters.AddWithValue("@password", password);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                user.UserId = reader.GetInt32(0);
                user.Username = reader.GetString(1);
                return user;
            }
            else
                return null;



        }
    }
}