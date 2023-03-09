using static System.Net.Mime.MediaTypeNames;
using System;
using RoskildeStudentHousing.Models;
using System.Data.SqlClient;

namespace RoskildeStudentHousing.Services.SQLServices
{
    public class SQLDormitory //Should Work (Untested)
    {
        static string ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog = RoskildeStudentHousingDB; Integrated Security = True; Connect Timeout = 30; Encrypt=False;";

        #region Get All Dorms
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
        #endregion

        #region Add Dorm
        public static void AddDorm(Dormitory dorm)
        {
            string query = $"insert into Dormitory( DormitoryNo, Name, Address) values( @DormitoryNo, @Name, @Address);";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                {

                    command.Parameters.AddWithValue("@Dormitory", dorm.DormitoryNo);
                    command.Parameters.AddWithValue("@Name", dorm.Name);
                    command.Parameters.AddWithValue("@Address", dorm.Address);
            
                    int affectedRows = command.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region Update Dorm
        public static void UpdateDorm(Dormitory dorm)
        {
            string query = $"UPDATE Dormitory SET Name = @Name, Address = @Address WHERE Id = {dorm.DormitoryNo};";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                {
                    command.Parameters.AddWithValue("@Name", dorm.Name);
                    command.Parameters.AddWithValue("@Address", dorm.Address);         
                    int affectedRows = command.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region Delete Dorm
        public static void DeleteDorm(Dormitory dorm)
        {
            string query = $"DELETE FROM Dormitory WHERE Id = {dorm.DormitoryNo};";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                {
                    int affectedRows = command.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region Get Dorm By Id
        public static Dormitory GetDormById(int id)
        {
            Dormitory dorm = new Dormitory();
            string query = $"SELECT * FROM Dormitory WHERE Id = {id};";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dorm.DormitoryNo = Convert.ToInt32(reader[0]);
                        dorm.Name = Convert.ToString(reader[1]);
                        dorm.Address = Convert.ToString(reader[2]);
                        
                    }
                }
            }
            return dorm;
        }
        #endregion

        #region Filter By Name or Address
        public static IEnumerable<Dormitory> FilterDormsByName(string filter)
        {
            List<Dormitory> dormList = new List<Dormitory>();
            string query = $"SELECT * FROM Dormitory WHERE Name LIKE '%{filter}%' OR Address LIKE '%{filter}%';";

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
        #endregion

        #region Get Fucking Everything By Dorm
        public static IEnumerable<LeasingRoomStudentDorm> GetAllCollectedInformationFromDorm(string dorm)
        {
            List<LeasingRoomStudentDorm> roomList = new List<LeasingRoomStudentDorm>();
            string query = $"SELECT r.Id AS RoomId, d.address,d.Name, r.Price,r.Type AS RoomType FROM Room AS r JOIN Dormitory AS d ON d.Id = r.DormId WHERE r.DormId = {dorm}";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        LeasingRoomStudentDorm r = new LeasingRoomStudentDorm();
                        r.StudentId = Convert.ToString(reader[0]);
                        r.StudentName = Convert.ToString(reader[1]);
                        r.RoomId = Convert.ToInt32(reader[2]);
                        r.Address = Convert.ToString(reader[3]);
                        r.DormName = Convert.ToString(reader[4]);
                        r.Price = Convert.ToInt32(reader[5]);
                        r.RoomType = Convert.ToString(reader[6]);
                        r.DateFrom = Convert.ToDateTime(reader[7]);
                        r.DateTo = Convert.ToDateTime(reader[8]);

                        roomList.Add(r);
                    }
                }
            }
            return roomList;
        }
        #endregion

    }
}
