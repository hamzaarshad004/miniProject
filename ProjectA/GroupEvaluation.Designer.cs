namespace ProjectA
{
    partial class GroupEvaluation
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
            this.cmbGroupId = new System.Windows.Forms.ComboBox();
            this.cmbEvalId = new System.Windows.Forms.ComboBox();
            this.dtEvalDate = new System.Windows.Forms.DateTimePicker();
            this.txtObtainMarks = new System.Windows.Forms.TextBox();
            this.lblGroupId = new System.Windows.Forms.Label();
            this.lblEvalId = new System.Windows.Forms.Label();
            this.lblObtainedMarks = new System.Windows.Forms.Label();
            this.lblEvalDate = new System.Windows.Forms.Label();
            this.cmdSubmit = new System.Windows.Forms.Button();
            this.dgvGroupEvals = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblBack = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupEvals)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbGroupId
            // 
            this.cmbGroupId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGroupId.FormattingEnabled = true;
            this.cmbGroupId.Location = new System.Drawing.Point(512, 66);
            this.cmbGroupId.Name = "cmbGroupId";
            this.cmbGroupId.Size = new System.Drawing.Size(200, 24);
            this.cmbGroupId.TabIndex = 0;
            this.cmbGroupId.SelectedIndexChanged += new System.EventHandler(this.cmbGroupId_SelectedIndexChanged);
            // 
            // cmbEvalId
            // 
            this.cmbEvalId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEvalId.FormattingEnabled = true;
            this.cmbEvalId.Location = new System.Drawing.Point(512, 120);
            this.cmbEvalId.Name = "cmbEvalId";
            this.cmbEvalId.Size = new System.Drawing.Size(200, 24);
            this.cmbEvalId.TabIndex = 1;
            // 
            // dtEvalDate
            // 
            this.dtEvalDate.Location = new System.Drawing.Point(512, 224);
            this.dtEvalDate.Name = "dtEvalDate";
            this.dtEvalDate.Size = new System.Drawing.Size(200, 22);
            this.dtEvalDate.TabIndex = 2;
            // 
            // txtObtainMarks
            // 
            this.txtObtainMarks.Location = new System.Drawing.Point(512, 172);
            this.txtObtainMarks.Name = "txtObtainMarks";
            this.txtObtainMarks.Size = new System.Drawing.Size(200, 22);
            this.txtObtainMarks.TabIndex = 3;
            // 
            // lblGroupId
            // 
            this.lblGroupId.AutoSize = true;
            this.lblGroupId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupId.Location = new System.Drawing.Point(183, 66);
            this.lblGroupId.Name = "lblGroupId";
            this.lblGroupId.Size = new System.Drawing.Size(83, 24);
            this.lblGroupId.TabIndex = 4;
            this.lblGroupId.Text = "Group Id";
            // 
            // lblEvalId
            // 
            this.lblEvalId.AutoSize = true;
            this.lblEvalId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvalId.Location = new System.Drawing.Point(183, 118);
            this.lblEvalId.Name = "lblEvalId";
            this.lblEvalId.Size = new System.Drawing.Size(153, 24);
            this.lblEvalId.TabIndex = 5;
            this.lblEvalId.Text = "Evaluation Name";
            // 
            // lblObtainedMarks
            // 
            this.lblObtainedMarks.AutoSize = true;
            this.lblObtainedMarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObtainedMarks.Location = new System.Drawing.Point(183, 170);
            this.lblObtainedMarks.Name = "lblObtainedMarks";
            this.lblObtainedMarks.Size = new System.Drawing.Size(142, 24);
            this.lblObtainedMarks.TabIndex = 6;
            this.lblObtainedMarks.Text = "Obtained Marks";
            // 
            // lblEvalDate
            // 
            this.lblEvalDate.AutoSize = true;
            this.lblEvalDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvalDate.Location = new System.Drawing.Point(183, 222);
            this.lblEvalDate.Name = "lblEvalDate";
            this.lblEvalDate.Size = new System.Drawing.Size(140, 24);
            this.lblEvalDate.TabIndex = 7;
            this.lblEvalDate.Text = "Evaluation Date";
            // 
            // cmdSubmit
            // 
            this.cmdSubmit.Location = new System.Drawing.Point(605, 282);
            this.cmdSubmit.Name = "cmdSubmit";
            this.cmdSubmit.Size = new System.Drawing.Size(106, 32);
            this.cmdSubmit.TabIndex = 8;
            this.cmdSubmit.Text = "Submit";
            this.cmdSubmit.UseVisualStyleBackColor = true;
            this.cmdSubmit.Click += new System.EventHandler(this.cmdSubmit_Click);
            // 
            // dgvGroupEvals
            // 
            this.dgvGroupEvals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroupEvals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.Delete});
            this.dgvGroupEvals.Location = new System.Drawing.Point(154, 343);
            this.dgvGroupEvals.Name = "dgvGroupEvals";
            this.dgvGroupEvals.RowTemplate.Height = 24;
            this.dgvGroupEvals.Size = new System.Drawing.Size(609, 293);
            this.dgvGroupEvals.TabIndex = 9;
            this.dgvGroupEvals.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGroupEvals_CellContentClick);
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit Evaluation";
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete Evaluation";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.Location = new System.Drawing.Point(743, 645);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(166, 24);
            this.lblBack.TabIndex = 18;
            this.lblBack.TabStop = true;
            this.lblBack.Text = "Back to Main Page";
            this.lblBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblBack_LinkClicked);
            // 
            // GroupEvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 678);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.dgvGroupEvals);
            this.Controls.Add(this.cmdSubmit);
            this.Controls.Add(this.lblEvalDate);
            this.Controls.Add(this.lblObtainedMarks);
            this.Controls.Add(this.lblEvalId);
            this.Controls.Add(this.lblGroupId);
            this.Controls.Add(this.txtObtainMarks);
            this.Controls.Add(this.dtEvalDate);
            this.Controls.Add(this.cmbEvalId);
            this.Controls.Add(this.cmbGroupId);
            this.Name = "GroupEvaluation";
            this.Text = "GroupEvaluation";
            this.Load += new System.EventHandler(this.GroupEvaluation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupEvals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbGroupId;
        private System.Windows.Forms.ComboBox cmbEvalId;
        private System.Windows.Forms.DateTimePicker dtEvalDate;
        private System.Windows.Forms.TextBox txtObtainMarks;
        private System.Windows.Forms.Label lblGroupId;
        private System.Windows.Forms.Label lblEvalId;
        private System.Windows.Forms.Label lblObtainedMarks;
        private System.Windows.Forms.Label lblEvalDate;
        private System.Windows.Forms.Button cmdSubmit;
        private System.Windows.Forms.DataGridView dgvGroupEvals;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.LinkLabel lblBack;
    }
}