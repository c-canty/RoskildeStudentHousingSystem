using RoskildeStudentHousing.Models;
using System.Data.SqlClient;

namespace RoskildeStudentHousing.Services.SQLServices
{
    public class SQLRoom // Should Work (Untested)
    {
        static string ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog = RoskildeStudentHousingDB; Integrated Security = True; Connect Timeout = 30; Encrypt=False;";

        #region Get All Rooms
        public static List<Room> GetAllRooms()
        {
            List<Room> roomList = new List<Room>();
            string query = "SELECT * FROM Room;";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Room r = new Room();
                        r.RoomNo = Convert.ToInt32(reader[0]);                       
                        r.Type = Convert.ToString(reader[1]);
                        r.Price = Convert.ToInt32(reader[2]);
                        r.DormitoryNo = Convert.ToInt32(reader[3]);
                        
                        roomList.Add(r);
                    }
                }
            }
            return roomList;
        }
        #endregion

        #region Add Room
        public static void AddRoom(Room r)
        {
            string query = $"insert into Room( RoomNo, DormitoryNo, Price, Type) values( @RoomNo, @DormitoryNo, @Price, @Type);";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                {

                    command.Parameters.AddWithValue("@RoomNo", r.RoomNo);
                    command.Parameters.AddWithValue("@DormitoryNo", r.DormitoryNo);
                    command.Parameters.AddWithValue("@Price", r.Price);
                    command.Parameters.AddWithValue("@Type", r.Type);

                    int affectedRows = command.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region Update Room
        public static void UpdateRoom(Room r)
        {
            string query = $"UPDATE Room SET Price = @Price, WHERE Id = {r.RoomNo} AND DormiD = {r.DormitoryNo};";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                {
                    command.Parameters.AddWithValue("@Price", r.Price);                    
                    int affectedRows = command.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region Delete Room
        public static void DeleteStudent(Room r)
        {
            string query = $"DELETE FROM Room WHERE Id = {r.RoomNo} AND DormiD = {r.DormitoryNo};";
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

        #region Get Room By Id
        public static Room GetRoomById(string rid, int did)
        {
            Room r = new Room();
            string query = $"SELECT * FROM Student WHERE Id = {rid} AND DormiD = {did};";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        r.RoomNo = Convert.ToInt32(reader[0]);
                        r.Type = Convert.ToString(reader[1]);
                        r.Price = Convert.ToInt32(reader[2]);
                        r.DormitoryNo = Convert.ToInt32(reader[3]);
                    }
                }
            }
            return r;
        }
        #endregion

        #region Filter By Number
        public static IEnumerable<Room> FilterDormsByName(string filter)
        {
            List<Room> roomList = new List<Room>();
            string query = $"SELECT * FROM Room WHERE Id LIKE {filter};";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Room r = new Room();
                        r.RoomNo = Convert.ToInt32(reader[0]);
                        r.Type = Convert.ToString(reader[1]);
                        r.Price = Convert.ToInt32(reader[2]);
                        r.DormitoryNo = Convert.ToInt32(reader[3]);
                        roomList.Add(r);
                    }
                }
            }
            return roomList;
        }
        #endregion

        #region Filter By Type
        public static IEnumerable<Room> FilterDormsByType(string filter)
        {
            List<Room> roomList = new List<Room>();
            string query = $"SELECT * FROM Room WHERE Type = {filter};";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Room r = new Room();
                        r.RoomNo = Convert.ToInt32(reader[0]);
                        r.Type = Convert.ToString(reader[1]);
                        r.Price = Convert.ToInt32(reader[2]);
                        r.DormitoryNo = Convert.ToInt32(reader[3]);
                        roomList.Add(r);
                    }
                }
            }
            return roomList;
        }

        #endregion

        #region Filter By Price
        public static IEnumerable<Room> FilterDormsByPrice(int min, int max)
        {
            List<Room> roomList = new List<Room>();
            string query = $"SELECT * FROM Room WHERE Price BEWTWEEN {min} AND {max};";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Room r = new Room();
                        r.RoomNo = Convert.ToInt32(reader[0]);
                        r.Type = Convert.ToString(reader[1]);
                        r.Price = Convert.ToInt32(reader[2]);
                        r.DormitoryNo = Convert.ToInt32(reader[3]);
                        roomList.Add(r);
                    }
                }
            }
            return roomList;
        }
        #endregion

        #region Filter By Dorm
        public static IEnumerable<Room> FilterRoomsByDormId(int dorm)
        {
            List<Room> roomList = new List<Room>();
            string query = $"SELECT * FROM Room WHERE DormId = {dorm};";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Room r = new Room();
                        r.RoomNo = Convert.ToInt32(reader[0]);
                        r.Type = Convert.ToString(reader[1]);
                        r.Price = Convert.ToInt32(reader[2]);
                        r.DormitoryNo = Convert.ToInt32(reader[3]);
                        roomList.Add(r);
                    }
                }
            }
            return roomList;
        }
        #endregion

        #region Get Fucking Everything By Room
        public static IEnumerable<LeasingRoomStudentDorm> GetAllCollectedInformationFromRoom(int id)
        {
            List<LeasingRoomStudentDorm> roomList = new List<LeasingRoomStudentDorm>();
            string query = $"SELECT s.Id AS StudentId, s.Name AS StudentName, r.Id AS RoomId, d.address,d.Name, r.Price,r.Type AS RoomType,l.DateFrom,l.DateTo FROM Leasing AS l JOIN Student AS s ON s.Id = l.StudentId JOIN Dormitory AS d ON d.Id = l.DormId JOIN Room AS r ON r.Id = l.RoomId WHERE r.Id = {id};";

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
