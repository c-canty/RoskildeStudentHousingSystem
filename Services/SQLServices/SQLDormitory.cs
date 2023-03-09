using static System.Net.Mime.MediaTypeNames;
using System;
using RoskildeStudentHousing.Models;
using System.Data.SqlClient;
using System.Security.Cryptography;

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
            string query = $"insert into Dormitory(Id, Name, Address) values(@Id, @Name, @Address);";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                {

                    command.Parameters.AddWithValue("@Id", dorm.DormitoryNo);
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
        public static IEnumerable<DormsRooms> GetAllCollectedInformationFromDorm(string dorm)
        {
            List<DormsRooms> roomList = new List<DormsRooms>();
            string query = $"select * from Dormitory join Room on Dormitory.Id = Room.DormId and Dormitory.Id = {dorm}";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DormsRooms Droom = new DormsRooms();
                        Droom.DormitoryNo = Convert.ToInt32(reader[0]);
                        Droom.Name = Convert.ToString(reader[1]);
                        Droom.Address = Convert.ToString(reader[2]);
                        Droom.RoomNo = Convert.ToInt32(reader[3]);
                        Droom.Type = Convert.ToString(reader[4]);
                        Droom.Price = Convert.ToInt32(reader[5]);                        

                        roomList.Add(Droom);
                    }
                }
            }
            return roomList;
        }
        #endregion

        public static IEnumerable<LeasingRoomStudentDorm> GetAllCollectedInformationFromDorm2(string dorm)
        {
            List<LeasingRoomStudentDorm> roomList = new List<LeasingRoomStudentDorm>();
            string query = $"SELECT s.Id AS StudentId, s.Name AS StudentName, r.Id AS RoomId, d.address,d.Name, r.Price,r.Type AS RoomType,l.DateFrom,l.DateTo, l.Id FROM Leasing AS l JOIN Student AS s ON s.Id = l.StudentId JOIN Dormitory AS d ON d.Id = l.DormId JOIN Room AS r ON r.Id = l.RoomId WHERE d.Name LIKE '%{dorm}%';";
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
                        r.LeasingId = Convert.ToInt32(reader[9]);

                        roomList.Add(r);
                    }
                }
            }
            return roomList;
        }

    }
}
