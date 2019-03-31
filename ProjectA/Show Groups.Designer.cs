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
            this.SeeStudents = new System.Windows.Forms.DataGridViewButtonColumn();
            this.AssignStudent = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvViewStudents = new System.Windows.Forms.DataGridView();
            this.Change = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGroups
            // 
            this.dgvGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroups.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AssignStudent,
            this.SeeStudents});
            this.dgvGroups.Location = new System.Drawing.Point(75, 71);
            this.dgvGroups.Name = "dgvGroups";
            this.dgvGroups.RowTemplate.Height = 24;
            this.dgvGroups.Size = new System.Drawing.Size(668, 378);
            this.dgvGroups.TabIndex = 0;
            this.dgvGroups.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGroups_CellContentClick);
            // 
            // SeeStudents
            // 
            this.SeeStudents.HeaderText = "View Assigned Students";
            this.SeeStudents.Name = "SeeStudents";
            this.SeeStudents.Text = "View";
            this.SeeStudents.UseColumnTextForButtonValue = true;
            // 
            // AssignStudent
            // 
            this.AssignStudent.HeaderText = "Assign Students";
            this.AssignStudent.Name = "AssignStudent";
            this.AssignStudent.Text = "Assign";
            this.AssignStudent.UseColumnTextForButtonValue = true;
            // 
            // dgvViewStudents
            // 
            this.dgvViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Change});
            this.dgvViewStudents.Location = new System.Drawing.Point(75, 515);
            this.dgvViewStudents.Name = "dgvViewStudents";
            this.dgvViewStudents.RowTemplate.Height = 24;
            this.dgvViewStudents.Size = new System.Drawing.Size(668, 371);
            this.dgvViewStudents.TabIndex = 1;
            this.dgvViewStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViewStudents_CellContentClick);
            // 
            // Change
            // 
            this.Change.HeaderText = "Change Status";
            this.Change.Name = "Change";
            this.Change.Text = "Change";
            this.Change.UseColumnTextForButtonValue = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "- Shows Created Groups";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 473);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(480, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "- Shows Students in a Group When selected from above";
            // 
            // Show_Groups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(826, 898);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvViewStudents);
            this.Controls.Add(this.dgvGroups);
            this.Name = "Show_Groups";
            this.Text = "Show Groups";
            this.Load += new System.EventHandler(this.Show_Groups_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGroups;
        private System.Windows.Forms.DataGridViewButtonColumn AssignStudent;
        private System.Windows.Forms.DataGridViewButtonColumn SeeStudents;
        private System.Windows.Forms.DataGridView dgvViewStudents;
        private System.Windows.Forms.DataGridViewButtonColumn Change;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}