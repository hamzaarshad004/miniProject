namespace ProjectA
{
    partial class Login
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStudents = new System.Windows.Forms.Button();
            this.btnAdvisors = new System.Windows.Forms.Button();
            this.btnProjects = new System.Windows.Forms.Button();
            this.btnEvaluations = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.btnEvaluations);
            this.groupBox1.Controls.Add(this.btnProjects);
            this.groupBox1.Controls.Add(this.btnAdvisors);
            this.groupBox1.Controls.Add(this.btnStudents);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(118, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(557, 230);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FYPs Management";
            // 
            // btnStudents
            // 
            this.btnStudents.Location = new System.Drawing.Point(98, 45);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(172, 59);
            this.btnStudents.TabIndex = 0;
            this.btnStudents.Text = "Students";
            this.btnStudents.UseVisualStyleBackColor = true;
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);
            // 
            // btnAdvisors
            // 
            this.btnAdvisors.Location = new System.Drawing.Point(285, 45);
            this.btnAdvisors.Name = "btnAdvisors";
            this.btnAdvisors.Size = new System.Drawing.Size(172, 59);
            this.btnAdvisors.TabIndex = 1;
            this.btnAdvisors.Text = "Advisors";
            this.btnAdvisors.UseVisualStyleBackColor = true;
            this.btnAdvisors.Click += new System.EventHandler(this.btnAdvisors_Click);
            // 
            // btnProjects
            // 
            this.btnProjects.Location = new System.Drawing.Point(98, 133);
            this.btnProjects.Name = "btnProjects";
            this.btnProjects.Size = new System.Drawing.Size(172, 59);
            this.btnProjects.TabIndex = 2;
            this.btnProjects.Text = "Projects";
            this.btnProjects.UseVisualStyleBackColor = true;
            this.btnProjects.Click += new System.EventHandler(this.btnProjects_Click);
            // 
            // btnEvaluations
            // 
            this.btnEvaluations.Location = new System.Drawing.Point(285, 133);
            this.btnEvaluations.Name = "btnEvaluations";
            this.btnEvaluations.Size = new System.Drawing.Size(172, 59);
            this.btnEvaluations.TabIndex = 3;
            this.btnEvaluations.Text = "Evaluations";
            this.btnEvaluations.UseVisualStyleBackColor = true;
            this.btnEvaluations.Click += new System.EventHandler(this.btnEvaluations_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Login";
            this.Text = "Login Form";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEvaluations;
        private System.Windows.Forms.Button btnProjects;
        private System.Windows.Forms.Button btnAdvisors;
        private System.Windows.Forms.Button btnStudents;
    }
}

