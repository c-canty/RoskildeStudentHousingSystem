using RoskildeStudentHousing.Models;
using System.Data.SqlClient;

namespace RoskildeStudentHousing.Services.SQLServices
{
    public class SQLStudent
    {
        static string ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog = RoskildeStudentHousingDB; Integrated Security = True; Connect Timeout = 30; Encrypt=False;Trust Server Certificate=False;Application Intent = ReadWrite; Multi Subnet Failover=False";

        #region Get All Dorms
        public static List<Student> GetAllStudents()
        {
            List<Student> studentList = new List<Student>();
            string query = "SELECT * FROM Student;";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Student s = new Student();
                        s.StudentNo = Convert.ToString(reader[0]);
                        s.Name = Convert.ToString(reader[1]);
                        s.Address = Convert.ToString(reader[2]);
                        studentList.Add(s);
                    }
                }
            }
            return studentList;
        }
        #endregion

        #region Add Dorm
        public static void AddStudent(Student s)
        {
            string query = $"insert into Student( StudentNo, Name, Address) values( @StudentNo, @Name, @Address);";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                {

                    command.Parameters.AddWithValue("@StudentNo", s.StudentNo);
                    command.Parameters.AddWithValue("@Name", s.Name);
                    command.Parameters.AddWithValue("@Address", s.Address);

                    int affectedRows = command.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region Update Dorm
        public static void UpdateStudent(Student s)
        {
            string query = $"UPDATE Student SET Name = @Name, Address = @Address WHERE Id = {s.StudentNo};";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                {
                    command.Parameters.AddWithValue("@Name", s.Name);
                    command.Parameters.AddWithValue("@Address", s.Address);
                    int affectedRows = command.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region Delete Dorm
        public static void DeleteStudent(Student s)
        {
            string query = $"DELETE FROM Student WHERE Id = {s.StudentNo};";
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
        public static Student GetStudentById(string id)
        {
            Student s = new Student();
            string query = $"SELECT * FROM Student WHERE Id = {id};";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        s.StudentNo = Convert.ToString(reader[0]);
                        s.Name = Convert.ToString(reader[1]);
                        s.Address = Convert.ToString(reader[2]);

                    }
                }
            }
            return s;
        }
        #endregion

        #region Filter By Name or Address
        public static IEnumerable<Student> FilterDormsByName(string filter)
        {
            List<Student> studentList = new List<Student>();
            string query = $"SELECT * FROM Student WHERE Name LIKE '%{filter}%' OR Address LIKE '%{filter}%';";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Student s = new Student();
                        s.StudentNo = Convert.ToString(reader[0]);
                        s.Name = Convert.ToString(reader[1]);
                        s.Address = Convert.ToString(reader[2]);
                        studentList.Add(s);
                    }
                }
            }
            return studentList;
        }
        #endregion
    }
}
