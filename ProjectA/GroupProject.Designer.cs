namespace ProjectA
{
    partial class GroupProject
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
            this.cmbTitle = new System.Windows.Forms.ComboBox();
            this.cmbGroupId = new System.Windows.Forms.ComboBox();
            this.dtAssgmtDate = new System.Windows.Forms.DateTimePicker();
            this.lblProjectTitle = new System.Windows.Forms.Label();
            this.lblGroupId = new System.Windows.Forms.Label();
            this.lblAssgntDate = new System.Windows.Forms.Label();
            this.btnAssignProject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbTitle
            // 
            this.cmbTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTitle.FormattingEnabled = true;
            this.cmbTitle.Location = new System.Drawing.Point(360, 81);
            this.cmbTitle.Name = "cmbTitle";
            this.cmbTitle.Size = new System.Drawing.Size(267, 24);
            this.cmbTitle.TabIndex = 0;
            // 
            // cmbGroupId
            // 
            this.cmbGroupId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGroupId.FormattingEnabled = true;
            this.cmbGroupId.Location = new System.Drawing.Point(360, 143);
            this.cmbGroupId.Name = "cmbGroupId";
            this.cmbGroupId.Size = new System.Drawing.Size(267, 24);
            this.cmbGroupId.TabIndex = 1;
            // 
            // dtAssgmtDate
            // 
            this.dtAssgmtDate.Location = new System.Drawing.Point(360, 205);
            this.dtAssgmtDate.Name = "dtAssgmtDate";
            this.dtAssgmtDate.Size = new System.Drawing.Size(267, 22);
            this.dtAssgmtDate.TabIndex = 2;
            // 
            // lblProjectTitle
            // 
            this.lblProjectTitle.AutoSize = true;
            this.lblProjectTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectTitle.Location = new System.Drawing.Point(145, 81);
            this.lblProjectTitle.Name = "lblProjectTitle";
            this.lblProjectTitle.Size = new System.Drawing.Size(108, 24);
            this.lblProjectTitle.TabIndex = 3;
            this.lblProjectTitle.Text = "Project Title";
            // 
            // lblGroupId
            // 
            this.lblGroupId.AutoSize = true;
            this.lblGroupId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupId.Location = new System.Drawing.Point(145, 142);
            this.lblGroupId.Name = "lblGroupId";
            this.lblGroupId.Size = new System.Drawing.Size(83, 24);
            this.lblGroupId.TabIndex = 4;
            this.lblGroupId.Text = "Group Id";
            // 
            // lblAssgntDate
            // 
            this.lblAssgntDate.AutoSize = true;
            this.lblAssgntDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssgntDate.Location = new System.Drawing.Point(145, 203);
            this.lblAssgntDate.Name = "lblAssgntDate";
            this.lblAssgntDate.Size = new System.Drawing.Size(152, 24);
            this.lblAssgntDate.TabIndex = 5;
            this.lblAssgntDate.Text = "Assignment Date";
            // 
            // btnAssignProject
            // 
            this.btnAssignProject.Location = new System.Drawing.Point(535, 267);
            this.btnAssignProject.Name = "btnAssignProject";
            this.btnAssignProject.Size = new System.Drawing.Size(92, 35);
            this.btnAssignProject.TabIndex = 6;
            this.btnAssignProject.Text = "Submit";
            this.btnAssignProject.UseVisualStyleBackColor = true;
            this.btnAssignProject.Click += new System.EventHandler(this.btnAssignProject_Click);
            // 
            // GroupProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 391);
            this.Controls.Add(this.btnAssignProject);
            this.Controls.Add(this.lblAssgntDate);
            this.Controls.Add(this.lblGroupId);
            this.Controls.Add(this.lblProjectTitle);
            this.Controls.Add(this.dtAssgmtDate);
            this.Controls.Add(this.cmbGroupId);
            this.Controls.Add(this.cmbTitle);
            this.Name = "GroupProject";
            this.Text = "GroupProject";
            this.Load += new System.EventHandler(this.GroupProject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTitle;
        private System.Windows.Forms.ComboBox cmbGroupId;
        private System.Windows.Forms.DateTimePicker dtAssgmtDate;
        private System.Windows.Forms.Label lblProjectTitle;
        private System.Windows.Forms.Label lblGroupId;
        private System.Windows.Forms.Label lblAssgntDate;
        private System.Windows.Forms.Button btnAssignProject;
    }
}