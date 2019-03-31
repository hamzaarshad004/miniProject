namespace ProjectA
{
    partial class ProjectReports
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
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.lblGoBack = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReport
            // 
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Location = new System.Drawing.Point(51, 47);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.RowTemplate.Height = 24;
            this.dgvReport.Size = new System.Drawing.Size(1681, 639);
            this.dgvReport.TabIndex = 0;
            // 
            // lblGoBack
            // 
            this.lblGoBack.AutoSize = true;
            this.lblGoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoBack.Location = new System.Drawing.Point(12, 709);
            this.lblGoBack.Name = "lblGoBack";
            this.lblGoBack.Size = new System.Drawing.Size(81, 24);
            this.lblGoBack.TabIndex = 1;
            this.lblGoBack.TabStop = true;
            this.lblGoBack.Text = "Go Back";
            this.lblGoBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblGoBack_LinkClicked);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1629, 702);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "Save Report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProjectReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1802, 755);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblGoBack);
            this.Controls.Add(this.dgvReport);
            this.Name = "ProjectReports";
            this.Text = "ProjectReports";
            this.Load += new System.EventHandler(this.ProjectReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.LinkLabel lblGoBack;
        private System.Windows.Forms.Button button1;
    }
}