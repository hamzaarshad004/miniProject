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
            this.SuspendLayout();
            // 
            // lblCreationDate
            // 
            this.lblCreationDate.AutoSize = true;
            this.lblCreationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreationDate.Location = new System.Drawing.Point(115, 137);
            this.lblCreationDate.Name = "lblCreationDate";
            this.lblCreationDate.Size = new System.Drawing.Size(180, 24);
            this.lblCreationDate.TabIndex = 0;
            this.lblCreationDate.Text = "Select Creation Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "- Note: Group IDs will be automatically alloted";
            // 
            // btnCreateGroup
            // 
            this.btnCreateGroup.Location = new System.Drawing.Point(398, 386);
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
            this.lblAssignStudents.Location = new System.Drawing.Point(459, 459);
            this.lblAssignStudents.Name = "lblAssignStudents";
            this.lblAssignStudents.Size = new System.Drawing.Size(232, 24);
            this.lblAssignStudents.TabIndex = 4;
            this.lblAssignStudents.TabStop = true;
            this.lblAssignStudents.Text = "Assign Students to Groups";
            this.lblAssignStudents.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblAssignStudents_LinkClicked);
            // 
            // mcCreationDate
            // 
            this.mcCreationDate.Location = new System.Drawing.Point(366, 138);
            this.mcCreationDate.Name = "mcCreationDate";
            this.mcCreationDate.Size = new System.Drawing.Size(243, 22);
            this.mcCreationDate.TabIndex = 5;
            // 
            // CreateGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 492);
            this.Controls.Add(this.mcCreationDate);
            this.Controls.Add(this.lblAssignStudents);
            this.Controls.Add(this.btnCreateGroup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCreationDate);
            this.Name = "CreateGroup";
            this.Text = "CreateGroup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCreationDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateGroup;
        private System.Windows.Forms.LinkLabel lblAssignStudents;
        private System.Windows.Forms.DateTimePicker mcCreationDate;
    }
}