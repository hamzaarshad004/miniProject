using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectA
{
    public partial class MakeGroups : Form
    {
        public MakeGroups()
        {
            InitializeComponent();
        }

        private void MakeGroups_Load(object sender, EventArgs e)
        {
            lblAddAnother.Hide();
            lblAddAnother2.Hide();
            lblAddAnother3.Hide();

            cmbStudent2.Hide();
            cmbStudent3.Hide();
            cmbStudent4.Hide();
        }
    }
}
