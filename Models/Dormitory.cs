namespace RoskildeStudentHousing.Models
{
    public class Dormitory
    {
        public int DormitoryNo { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }


        public Dormitory(int dormitoryNo, string name, string address)
        {
            DormitoryNo = dormitoryNo;
            Name = name;
            Address = address;
        }

        public Dormitory()
        {
            
        }
    }
}
