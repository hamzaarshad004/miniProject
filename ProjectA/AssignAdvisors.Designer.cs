namespace ProjectA
{
    partial class AssignAdvisors
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
            this.lblProjectId = new System.Windows.Forms.Label();
            this.lblAdvisorId = new System.Windows.Forms.Label();
            this.lblAdvisorRole = new System.Windows.Forms.Label();
            this.lblAssignmentDate = new System.Windows.Forms.Label();
            this.cmbProjectId = new System.Windows.Forms.ComboBox();
            this.cmbAdvisorId = new System.Windows.Forms.ComboBox();
            this.cmbAdvisorRole = new System.Windows.Forms.ComboBox();
            this.dtAssignmentDate = new System.Windows.Forms.DateTimePicker();
            this.btnAssignAdvisor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProjectId
            // 
            this.lblProjectId.AutoSize = true;
            this.lblProjectId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectId.Location = new System.Drawing.Point(230, 93);
            this.lblProjectId.Name = "lblProjectId";
            this.lblProjectId.Size = new System.Drawing.Size(108, 24);
            this.lblProjectId.TabIndex = 0;
            this.lblProjectId.Text = "Project Title";
            // 
            // lblAdvisorId
            // 
            this.lblAdvisorId.AutoSize = true;
            this.lblAdvisorId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvisorId.Location = new System.Drawing.Point(230, 145);
            this.lblAdvisorId.Name = "lblAdvisorId";
            this.lblAdvisorId.Size = new System.Drawing.Size(93, 24);
            this.lblAdvisorId.TabIndex = 1;
            this.lblAdvisorId.Text = "Advisor Id";
            // 
            // lblAdvisorRole
            // 
            this.lblAdvisorRole.AutoSize = true;
            this.lblAdvisorRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvisorRole.Location = new System.Drawing.Point(230, 197);
            this.lblAdvisorRole.Name = "lblAdvisorRole";
            this.lblAdvisorRole.Size = new System.Drawing.Size(117, 24);
            this.lblAdvisorRole.TabIndex = 2;
            this.lblAdvisorRole.Text = "Advisor Role";
            // 
            // lblAssignmentDate
            // 
            this.lblAssignmentDate.AutoSize = true;
            this.lblAssignmentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssignmentDate.Location = new System.Drawing.Point(230, 249);
            this.lblAssignmentDate.Name = "lblAssignmentDate";
            this.lblAssignmentDate.Size = new System.Drawing.Size(152, 24);
            this.lblAssignmentDate.TabIndex = 3;
            this.lblAssignmentDate.Text = "Assignment Date";
            // 
            // cmbProjectId
            // 
            this.cmbProjectId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProjectId.FormattingEnabled = true;
            this.cmbProjectId.Location = new System.Drawing.Point(474, 95);
            this.cmbProjectId.Name = "cmbProjectId";
            this.cmbProjectId.Size = new System.Drawing.Size(200, 24);
            this.cmbProjectId.TabIndex = 4;
            this.cmbProjectId.SelectedIndexChanged += new System.EventHandler(this.cmbProjectId_SelectedIndexChanged);
            // 
            // cmbAdvisorId
            // 
            this.cmbAdvisorId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAdvisorId.FormattingEnabled = true;
            this.cmbAdvisorId.Location = new System.Drawing.Point(474, 147);
            this.cmbAdvisorId.Name = "cmbAdvisorId";
            this.cmbAdvisorId.Size = new System.Drawing.Size(200, 24);
            this.cmbAdvisorId.TabIndex = 5;
            this.cmbAdvisorId.SelectedIndexChanged += new System.EventHandler(this.cmbAdvisorId_SelectedIndexChanged);
            // 
            // cmbAdvisorRole
            // 
            this.cmbAdvisorRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAdvisorRole.FormattingEnabled = true;
            this.cmbAdvisorRole.Location = new System.Drawing.Point(474, 199);
            this.cmbAdvisorRole.Name = "cmbAdvisorRole";
            this.cmbAdvisorRole.Size = new System.Drawing.Size(200, 24);
            this.cmbAdvisorRole.TabIndex = 6;
            // 
            // dtAssignmentDate
            // 
            this.dtAssignmentDate.Location = new System.Drawing.Point(474, 251);
            this.dtAssignmentDate.Name = "dtAssignmentDate";
            this.dtAssignmentDate.Size = new System.Drawing.Size(200, 22);
            this.dtAssignmentDate.TabIndex = 7;
            // 
            // btnAssignAdvisor
            // 
            this.btnAssignAdvisor.Location = new System.Drawing.Point(585, 312);
            this.btnAssignAdvisor.Name = "btnAssignAdvisor";
            this.btnAssignAdvisor.Size = new System.Drawing.Size(89, 34);
            this.btnAssignAdvisor.TabIndex = 8;
            this.btnAssignAdvisor.Text = "Submit";
            this.btnAssignAdvisor.UseVisualStyleBackColor = true;
            this.btnAssignAdvisor.Click += new System.EventHandler(this.btnAssignAdvisor_Click);
            // 
            // AssignAdvisors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 540);
            this.Controls.Add(this.btnAssignAdvisor);
            this.Controls.Add(this.dtAssignmentDate);
            this.Controls.Add(this.cmbAdvisorRole);
            this.Controls.Add(this.cmbAdvisorId);
            this.Controls.Add(this.cmbProjectId);
            this.Controls.Add(this.lblAssignmentDate);
            this.Controls.Add(this.lblAdvisorRole);
            this.Controls.Add(this.lblAdvisorId);
            this.Controls.Add(this.lblProjectId);
            this.Name = "AssignAdvisors";
            this.Text = "AssignAdvisors";
            this.Load += new System.EventHandler(this.AssignAdvisors_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProjectId;
        private System.Windows.Forms.Label lblAdvisorId;
        private System.Windows.Forms.Label lblAdvisorRole;
        private System.Windows.Forms.Label lblAssignmentDate;
        private System.Windows.Forms.ComboBox cmbProjectId;
        private System.Windows.Forms.ComboBox cmbAdvisorId;
        private System.Windows.Forms.ComboBox cmbAdvisorRole;
        private System.Windows.Forms.DateTimePicker dtAssignmentDate;
        private System.Windows.Forms.Button btnAssignAdvisor;
    }
}