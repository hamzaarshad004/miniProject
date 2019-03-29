namespace ProjectA
{
    partial class Show_Groups
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvGroups = new System.Windows.Forms.DataGridView();
            this.AssignStudent = new System.Windows.Forms.DataGridViewButtonColumn();
            this.SeeStudents = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGroups
            // 
            this.dgvGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroups.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AssignStudent,
            this.SeeStudents});
            this.dgvGroups.Location = new System.Drawing.Point(83, 123);
            this.dgvGroups.Name = "dgvGroups";
            this.dgvGroups.RowTemplate.Height = 24;
            this.dgvGroups.Size = new System.Drawing.Size(638, 348);
            this.dgvGroups.TabIndex = 0;
            this.dgvGroups.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGroups_CellContentClick);
            // 
            // AssignStudent
            // 
            this.AssignStudent.HeaderText = "Assign Students";
            this.AssignStudent.Name = "AssignStudent";
            this.AssignStudent.Text = "Assign";
            this.AssignStudent.UseColumnTextForButtonValue = true;
            // 
            // SeeStudents
            // 
            this.SeeStudents.HeaderText = "View Assigned Students";
            this.SeeStudents.Name = "SeeStudents";
            this.SeeStudents.Text = "View";
            this.SeeStudents.UseColumnTextForButtonValue = true;
            // 
            // Show_Groups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 528);
            this.Controls.Add(this.dgvGroups);
            this.Name = "Show_Groups";
            this.Text = "Show Groups";
            this.Load += new System.EventHandler(this.Show_Groups_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGroups;
        private System.Windows.Forms.DataGridViewButtonColumn AssignStudent;
        private System.Windows.Forms.DataGridViewButtonColumn SeeStudents;
    }
}