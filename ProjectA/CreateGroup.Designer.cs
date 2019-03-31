namespace ProjectA
{
    partial class CreateGroup
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
            this.lblCreationDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateGroup = new System.Windows.Forms.Button();
            this.lblAssignStudents = new System.Windows.Forms.LinkLabel();
            this.mcCreationDate = new System.Windows.Forms.DateTimePicker();
            this.dgvSelectedStudents = new System.Windows.Forms.DataGridView();
            this.cmbRegNo = new System.Windows.Forms.ComboBox();
            this.lblRegNo = new System.Windows.Forms.Label();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCreationDate
            // 
            this.lblCreationDate.AutoSize = true;
            this.lblCreationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreationDate.Location = new System.Drawing.Point(119, 27);
            this.lblCreationDate.Name = "lblCreationDate";
            this.lblCreationDate.Size = new System.Drawing.Size(180, 24);
            this.lblCreationDate.TabIndex = 0;
            this.lblCreationDate.Text = "Select Creation Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 462);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "- Note: Group IDs will be automatically alloted";
            // 
            // btnCreateGroup
            // 
            this.btnCreateGroup.Location = new System.Drawing.Point(398, 518);
            this.btnCreateGroup.Name = "btnCreateGroup";
            this.btnCreateGroup.Size = new System.Drawing.Size(106, 33);
            this.btnCreateGroup.TabIndex = 3;
            this.btnCreateGroup.Text = "Submit";
            this.btnCreateGroup.UseVisualStyleBackColor = true;
            this.btnCreateGroup.Click += new System.EventHandler(this.btnCreateGroup_Click);
            // 
            // lblAssignStudents
            // 
            this.lblAssignStudents.AutoSize = true;
            this.lblAssignStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssignStudents.Location = new System.Drawing.Point(459, 553);
            this.lblAssignStudents.Name = "lblAssignStudents";
            this.lblAssignStudents.Size = new System.Drawing.Size(232, 24);
            this.lblAssignStudents.TabIndex = 4;
            this.lblAssignStudents.TabStop = true;
            this.lblAssignStudents.Text = "Assign Students to Groups";
            this.lblAssignStudents.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblAssignStudents_LinkClicked);
            // 
            // mcCreationDate
            // 
            this.mcCreationDate.Location = new System.Drawing.Point(370, 28);
            this.mcCreationDate.Name = "mcCreationDate";
            this.mcCreationDate.Size = new System.Drawing.Size(243, 22);
            this.mcCreationDate.TabIndex = 5;
            // 
            // dgvSelectedStudents
            // 
            this.dgvSelectedStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectedStudents.Location = new System.Drawing.Point(123, 223);
            this.dgvSelectedStudents.Name = "dgvSelectedStudents";
            this.dgvSelectedStudents.RowTemplate.Height = 24;
            this.dgvSelectedStudents.Size = new System.Drawing.Size(490, 219);
            this.dgvSelectedStudents.TabIndex = 6;
            // 
            // cmbRegNo
            // 
            this.cmbRegNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRegNo.FormattingEnabled = true;
            this.cmbRegNo.Location = new System.Drawing.Point(370, 88);
            this.cmbRegNo.Name = "cmbRegNo";
            this.cmbRegNo.Size = new System.Drawing.Size(183, 24);
            this.cmbRegNo.TabIndex = 7;
            // 
            // lblRegNo
            // 
            this.lblRegNo.AutoSize = true;
            this.lblRegNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegNo.Location = new System.Drawing.Point(119, 88);
            this.lblRegNo.Name = "lblRegNo";
            this.lblRegNo.Size = new System.Drawing.Size(138, 24);
            this.lblRegNo.TabIndex = 8;
            this.lblRegNo.Text = "Registration No";
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(435, 176);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(118, 31);
            this.btnAddStudent.TabIndex = 9;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(119, 137);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(60, 24);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Text = "Status";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Active",
            "InActive"});
            this.cmbStatus.Location = new System.Drawing.Point(370, 137);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(183, 24);
            this.cmbStatus.TabIndex = 10;
            // 
            // CreateGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 597);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.lblRegNo);
            this.Controls.Add(this.cmbRegNo);
            this.Controls.Add(this.dgvSelectedStudents);
            this.Controls.Add(this.mcCreationDate);
            this.Controls.Add(this.lblAssignStudents);
            this.Controls.Add(this.btnCreateGroup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCreationDate);
            this.Name = "CreateGroup";
            this.Text = "CreateGroup";
            this.Load += new System.EventHandler(this.CreateGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCreationDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateGroup;
        private System.Windows.Forms.LinkLabel lblAssignStudents;
        private System.Windows.Forms.DateTimePicker mcCreationDate;
        private System.Windows.Forms.DataGridView dgvSelectedStudents;
        private System.Windows.Forms.ComboBox cmbRegNo;
        private System.Windows.Forms.Label lblRegNo;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
    }
}