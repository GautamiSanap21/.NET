using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace MVC_Connected.Models
{
    public class DataContext 
    {
        private readonly string? _connStr;

        public DataContext(IConfiguration config)
        {
            _connStr = config.GetConnectionString("Data");
        }

        public List<Emp> GetAllEmps()
        {
            List<Emp> emps = new List<Emp>();
            using(SqlConnection conn = new SqlConnection(_connStr))
            {
                conn.Open();
                using(SqlCommand cmd = new SqlCommand("select * from Emp", conn))
                {
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            emps.Add(new Emp()
                            {
                                Id = Convert.ToInt32(reader["ID"]),
                                Name = reader["Name"].ToString(),
                                Address = reader["Address"].ToString(),

                            });
                        }
                    }
                }

            }
            return emps;
        }
    }
}
