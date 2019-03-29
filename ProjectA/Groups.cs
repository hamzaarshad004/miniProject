using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ProjectA
{
    class Groups
    {
        private int groupID;
        private DateTime Created_On;
        private int NumberOfStudents;
        public static List<Groups> groups1 = new List<Groups>();

        public int GroupID { get => groupID; set => groupID = value; }
        public DateTime Created_On1 { get => Created_On; set => Created_On = value; }
        public int NumberOfStudents1 { get => NumberOfStudents; set => NumberOfStudents = value; }

        public static void ShowGroups()
        {
            groups1.Clear();
            SqlConnection con = new SqlConnection(AddProject.conStr);
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                string Fetch = "SELECT \"Group\".Id, \"Group\".Created_On,  COUNT(StudentId) As NumberOfStudents FROM [dbo].[Group] LEFT JOIN GroupStudent ON \"Group\".Id = GroupStudent.GroupId GROUP BY \"Group\".Id,\"Group\".Created_On";
                SqlCommand cmd = new SqlCommand(Fetch, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Groups group = new Groups();
                    group.GroupID = Convert.ToInt32(reader["Id"]);
                    group.Created_On1 = Convert.ToDateTime(reader["Created_On"]);
                    group.NumberOfStudents1 = Convert.ToInt32(reader["NumberOfStudents"]);
                    groups1.Add(group);
                }
            }
        }

        public static int checkNumberOfStudents(int id)
        {
            SqlConnection connection = new SqlConnection(AddProject.conStr);
            connection.Open();
            int check = 0;
            if (connection.State == ConnectionState.Open)
            {
                string query = "SELECT COUNT(StudentId) FROM GroupStudent WHERE GroupId = '"+id+"'";
                SqlCommand cmd = new SqlCommand(query, connection);
                check = (int)cmd.ExecuteScalar();

            }
            return check;
        }
    }
}
