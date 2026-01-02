

using Microsoft.Data.SqlClient;

namespace MVC_Database_Connectivity.Models
{
    public class DatabaseContext
    {
        private readonly string conString;
        public DatabaseContext(IConfiguration config)
        {
            conString = config.GetConnectionString("Gaurav");
        }

        public List<Student> getAllStudents()
        {
            List<Student> students = new List<Student>();
            using (
                SqlConnection con = new SqlConnection(conString)
                )
            {
                con.Open();
                using(
                    SqlCommand com = new SqlCommand("select * from student" , con)
                    )
                {
                    using(
                        SqlDataReader reader = com.ExecuteReader()
                        )
                    {
                        while (reader.Read())
                        {
                            students.Add(
                                new Student()
                                {
                                    SId = Convert.ToInt32(reader["SId"]),
                                    Name = reader["Name"].ToString(),
                                    Address = reader["Address"].ToString()
                                }
                                );
                        }
                    }
                }
            }
            return students;
        }
    }
}
