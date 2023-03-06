using static System.Net.Mime.MediaTypeNames;
using System;
using RoskildeStudentHousing.Models;
using System.Data.SqlClient;

namespace RoskildeStudentHousing.Services.SQLServices
{
    public class SQLDormitory
    {
        static string ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog = RoskildeStudentHousingDB; Integrated Security = True; Connect Timeout = 30; Encrypt=False;Trust Server Certificate=False;Application Intent = ReadWrite; Multi Subnet Failover=False";

        public static List<Dormitory> GetAllDorms()
        {
            List<Dormitory> dormList = new List<Dormitory>();
            string query = "SELECT * FROM Dormitory;";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Dormitory dorm = new Dormitory();
                        dorm.DormitoryNo = Convert.ToInt32(reader[0]);
                        dorm.Name = Convert.ToString(reader[1]);
                        dorm.Address = Convert.ToString(reader[2]);                      
                        dormList.Add(dorm);
                    }
                }
            }
            return dormList;
        }
    }
}
