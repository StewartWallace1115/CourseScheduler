using System;


using System.Data.SqlClient;
namespace CourseScheduler.Databases
{
    public class Database
    {
        SqlConnection sqlConnection;


        public SqlConnection Connect()
        {
            string connetionString = null;
            connetionString = getInformation();
            sqlConnection = new SqlConnection(connetionString);
            try
            {
                sqlConnection.Open();

                return sqlConnection;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public string getInformation()
        {
            string result = "Data Source={0};Initial Catalog={1};Integrated Security={2}";
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\stewart\source\repos\Course Scheduler\Course Scheduler\Res\sqllogin.txt");
            result = String.Format(result, lines);
            return result;
        }
        public void Close()
        {
            sqlConnection.Close();
        }

    }

}