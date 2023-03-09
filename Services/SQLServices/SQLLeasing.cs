using RoskildeStudentHousing.Models;
using System.Data.SqlClient;

namespace RoskildeStudentHousing.Services.SQLServices
{
    public class SQLLeasing
    {
        static string ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog = RoskildeStudentHousingDB; Integrated Security = True; Connect Timeout = 30; Encrypt=False;";

        #region Get All Leasings
        public static IEnumerable<Leasing> GetAllLeasings()
        {
            List<Leasing> leasingList = new List<Leasing>();
            string query = "SELECT * FROM Leasing;";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Leasing r = new Leasing();
                        r.LeasingNo = Convert.ToInt32(reader[0]);
                        r.DateTimeFrom = Convert.ToDateTime(reader[1]);
                        r.DateTimeTo = Convert.ToDateTime(reader[2]);
                        r.StudentNo = Convert.ToString(reader[3]);
                        r.RoomNo = Convert.ToInt32(reader[4]);
                        r.DormitoryNo = Convert.ToInt32(reader[5]);
                        leasingList.Add(r);
                    }
                }
            }
            return leasingList;
        }
        #endregion

        #region Add Leasing
        public static void AddLeasing(Leasing r)
        {
            string query = $"insert into Leasing( LeasingId, StudentId, DormId, RoomId, DateFrom, DateTo) values(  @LeasingId, @StudentId, @DormId, @RoomId, @DateFrom, @DateTo);";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                {
                    command.Parameters.AddWithValue("@LeasingId", r.LeasingNo);
                    command.Parameters.AddWithValue("@StudentId", r.StudentNo);
                    command.Parameters.AddWithValue("@DormId", r.DormitoryNo);
                    command.Parameters.AddWithValue("@RoomId", r.RoomNo);
                    command.Parameters.AddWithValue("@DateFrom", r.DateTimeFrom);
                    command.Parameters.AddWithValue("@DateTo", r.DateTimeTo);

                    int affectedRows = command.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region Update Leasing
        public static void UpdateLeasing(Leasing r)
        {
            string query = $"UPDATE Leasing SET DateFrom = @DateFrom, DateTo = @DateFrom WHERE Id = {r.LeasingNo};";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                {
                    command.Parameters.AddWithValue("@DateFrom", r.DateTimeFrom);
                    command.Parameters.AddWithValue("@DateTo", r.DateTimeTo);
                    int affectedRows = command.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region Delete Leasing
        public static void DeleteLeasing(Leasing r)
        {
            string query = $"DELETE FROM Leasing WHERE Id = {r.LeasingNo};";
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

        #region Get Leasing By Id
        public static Leasing GetLeasingById(string id)
        {
            Leasing r = new Leasing();
            string query = $"SELECT * FROM Leasing WHERE Id = {id};";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        r.LeasingNo = Convert.ToInt32(reader[0]);
                        r.DateTimeFrom = Convert.ToDateTime(reader[1]);
                        r.DateTimeTo = Convert.ToDateTime(reader[2]);
                        r.StudentNo = Convert.ToString(reader[3]);
                        r.RoomNo = Convert.ToInt32(reader[4]);
                        r.DormitoryNo = Convert.ToInt32(reader[5]);
                    }
                }
            }
            return r;
        }
        #endregion

        #region Filter By Room Number
        public static Leasing GetLeasingByRoomNumber(int id)
        {
            Leasing r = new Leasing();
            string query = $"SELECT * FROM Leasing WHERE RoomId = {id};";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        r.LeasingNo = Convert.ToInt32(reader[0]);
                        r.DateTimeFrom = Convert.ToDateTime(reader[1]);
                        r.DateTimeTo = Convert.ToDateTime(reader[2]);
                        r.StudentNo = Convert.ToString(reader[3]);
                        r.RoomNo = Convert.ToInt32(reader[4]);
                        r.DormitoryNo = Convert.ToInt32(reader[5]);
                    }
                }
            }
            return r;
        }
        #endregion

        #region Filter By Student Id
        public static IEnumerable<Leasing> GetLeasingsByStudentId(string id)
        {
            List<Leasing> leasingList = new List<Leasing>();
            string query = $"SELECT * FROM Leasing WHERE StudentId = {id};";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Leasing r = new Leasing();
                        r.LeasingNo = Convert.ToInt32(reader[0]);
                        r.DateTimeFrom = Convert.ToDateTime(reader[1]);
                        r.DateTimeTo = Convert.ToDateTime(reader[2]);
                        r.StudentNo = Convert.ToString(reader[3]);
                        r.RoomNo = Convert.ToInt32(reader[4]);
                        r.DormitoryNo = Convert.ToInt32(reader[5]);
                        leasingList.Add(r);
                    }
                }
            }
            return leasingList;
        }
        #endregion

        #region Filter By Dorm
        public static IEnumerable<Leasing> GetLeasingsByDormId(int id)
        {
            List<Leasing> leasingList = new List<Leasing>();
            string query = $"SELECT * FROM Leasing WHERE DormId = {id};";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Leasing r = new Leasing();
                        r.LeasingNo = Convert.ToInt32(reader[0]);
                        r.DateTimeFrom = Convert.ToDateTime(reader[1]);
                        r.DateTimeTo = Convert.ToDateTime(reader[2]);
                        r.StudentNo = Convert.ToString(reader[3]);
                        r.RoomNo = Convert.ToInt32(reader[4]);
                        r.DormitoryNo = Convert.ToInt32(reader[5]);
                        leasingList.Add(r);
                    }
                }
            }
            return leasingList;
        }
        #endregion

        #region Get Fucking Everything
        public static IEnumerable<LeasingRoomStudentDorm> GetAllCollectedInformation()
        {
            List<LeasingRoomStudentDorm> roomList = new List<LeasingRoomStudentDorm>();
            string query = $"SELECT s.Id AS StudentId, s.Name AS StudentName, r.Id AS RoomId, d.address,d.Name, r.Price,r.Type AS RoomType,l.DateFrom,l.DateTo, l.id FROM Leasing AS l JOIN Student AS s ON s.Id = l.StudentId JOIN Dormitory AS d ON d.Id = l.DormId JOIN Room AS r ON r.Id = l.RoomId;";

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
        #endregion

    }
}
