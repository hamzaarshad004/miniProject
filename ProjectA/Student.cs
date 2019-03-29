using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProjectA
{
    class Student
    {
        private int ID;
        private string Registration_Number;
        private string FirstName;
        private string LastName;
        private string Contact;
        private string Email;
        private DateTime DOB;
        private string Gender;
        public static List<Student> students = new List<Student>();

        public int ID1 { get => ID; set => ID = value; }
        public string Registration_Number1 { get => Registration_Number; set => Registration_Number = value; }
        public string FirstName1 { get => FirstName; set => FirstName = value; }
        public string LastName1 { get => LastName; set => LastName = value; }
        public string Contact1 { get => Contact; set => Contact = value; }
        public string Email1 { get => Email; set => Email = value; }
        public DateTime DOB1 { get => DOB; set => DOB = value; }
        public string Gender1 { get => Gender; set => Gender = value; }

        public static void ShowStudents()
        {
            students.Clear();
            SqlConnection connection = new SqlConnection(AddProject.conStr);
            connection.Open();
            if (connection.State == System.Data.ConnectionState.Open)
            {
                string query = "SELECT Person.Id, FirstName, LastName, Contact, Email, DateOfBirth, Gender, RegistrationNo FROM Person JOIN Student ON Person.Id = Student.Id ";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Student s = new Student();
                    s.ID1 = Convert.ToInt32(reader["Id"]);
                    s.FirstName1 = Convert.ToString(reader["FirstName"]);
                    s.LastName1 = Convert.ToString(reader["LastName"]);
                    s.Contact1 = Convert.ToString(reader["Contact"]);
                    s.Email1 = Convert.ToString(reader["Email"]);
                    s.DOB1 = Convert.ToDateTime(reader["DateOfBirth"]);
                    int temp = Convert.ToInt32(reader["Gender"]);
                    if (temp == 1)
                    {
                        s.Gender1 = "Male";
                    }
                    else
                    {
                        s.Gender1 = "Female";
                    }
                    s.Registration_Number1 = Convert.ToString(reader["RegistrationNo"]);

                    students.Add(s);
                }
            }
        }
    }
}
