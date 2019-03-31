using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectA
{
    class ProjectReport
    {
        private string Title;
        private int Advisor1_Id;
        private string Advisor1_Role;
        private int Advisor2_Id;
        private string Advisor2_Role;
        private int Advisor3_Id;
        private string Advisor3_Role;
        private string Student1_RegNo;
        private string Student_Name;
        private string Student2_RegNo;
        private string Student2_Name;
        private string Student3_RegNo;
        private string Student3_Name;
        private string Student4_RegNo;
        private string Student4_Name;

        public string P_Title { get => Title; set => Title = value; }
        public int Advisor_1_Id { get => Advisor1_Id; set => Advisor1_Id = value; }
        public string Advisor_1_Role{ get => Advisor1_Role; set => Advisor1_Role = value; }
        public int Advisor_2_Id { get => Advisor2_Id; set => Advisor2_Id = value; }
        public string Advisor_2_Role { get => Advisor2_Role; set => Advisor2_Role = value; }
        public int Advisor_3_Id { get => Advisor3_Id; set => Advisor3_Id = value; }
        public string Advisor_3_Role { get => Advisor3_Role; set => Advisor3_Role = value; }
        public string Student_1_RegNo { get => Student1_RegNo; set => Student1_RegNo = value; }
        public string Student_1_Name { get => Student_Name; set => Student_Name = value; }
        public string Student_2_RegNo { get => Student2_RegNo; set => Student2_RegNo = value; }
        public string Student_2_Name { get => Student2_Name; set => Student2_Name = value; }
        public string Student_3_RegNo { get => Student3_RegNo; set => Student3_RegNo = value; }
        public string Student_3_Name { get => Student3_Name; set => Student3_Name = value; }
        public string Student_4_RegNo { get => Student4_RegNo; set => Student4_RegNo = value; }
        public string Student_4_Name { get => Student4_Name; set => Student4_Name = value; }
    }
}
