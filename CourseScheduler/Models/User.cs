using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CourseScheduler.Models
{
    public class User
    {
        private int userId;
        private string username;
        private string password;

        public int UserId { get => userId; set => userId = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
    }
}