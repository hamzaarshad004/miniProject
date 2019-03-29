using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProjectA
{
    class Evaluation
    {
        private int Id;
        private string Name;
        private int TotalMarks;
        private int TotalWeightage;

        public int Id1 { get => Id; set => Id = value; }
        public string Name1 { get => Name; set => Name = value; }
        public int TotalMarks1 { get => TotalMarks; set => TotalMarks = value; }
        public int TotalWeightage1 { get => TotalWeightage; set => TotalWeightage = value; }

        public static List<Evaluation> Evaluations = new List<Evaluation>();

        public static void getEvaluations()
        {
            SqlConnection con = new SqlConnection(AddProject.conStr);
            con.Open();
            Evaluations.Clear();
            if (con.State == ConnectionState.Open)
            {
                string query = "SELECT * FROM Evaluation";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Evaluation e = new Evaluation();
                    e.Id1 = Convert.ToInt32(reader["Id"]);
                    e.Name1 = Convert.ToString(reader["Name"]);
                    e.TotalMarks1 = Convert.ToInt32(reader["TotalMarks"]);
                    e.TotalWeightage1 = Convert.ToInt32(reader["TotalWeightage"]);

                    Evaluations.Add(e);
                }
            }
        }
    }
}
