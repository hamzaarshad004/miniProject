using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProjectA
{
    class GroupEval
    {
        int GroupId;
        int EvalId;
        int ObtainedMarks;
        int TotalMarks;
        DateTime EvalDate;
        string EvalName;
        public static List<GroupEval> groupEvals = new List<GroupEval>();

        public int Group_Id { get => GroupId; set => GroupId = value; }
        public int Eval_Id { get => EvalId; set => EvalId = value; }
        public string Eval_Name { get => EvalName; set => EvalName = value; }
        public int Total_Marks { get => TotalMarks; set => TotalMarks = value; }
        public int Obtained_Marks { get => ObtainedMarks; set => ObtainedMarks = value; }
        public DateTime Eval_Date { get => EvalDate; set => EvalDate = value; }  

        public static void ShowGroupEvals()
        {
            groupEvals.Clear();
            SqlConnection con = new SqlConnection(AddProject.conStr);
            con.Open();
            
            if (con.State == ConnectionState.Open)
            {
                string fetch = "SELECT GroupId, EvaluationId, ObtainedMarks, EvaluationDate, Name, TotalMarks FROM GroupEvaluation JOIN Evaluation ON Evaluation.Id = GroupEvaluation.EvaluationId";
                SqlCommand cmd = new SqlCommand(fetch, con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    GroupEval ge = new GroupEval();

                    ge.Group_Id = Convert.ToInt32(reader["GroupId"]);
                    ge.Eval_Id = Convert.ToInt32(reader["EvaluationId"]);
                    ge.Obtained_Marks = Convert.ToInt32(reader["ObtainedMarks"]);
                    ge.Eval_Date = Convert.ToDateTime(reader["EvaluationDate"]);
                    ge.Eval_Name = Convert.ToString(reader["Name"]);
                    ge.Total_Marks = Convert.ToInt32(reader["TotalMarks"]);

                    groupEvals.Add(ge);
                }
            }
        }
    }
}
