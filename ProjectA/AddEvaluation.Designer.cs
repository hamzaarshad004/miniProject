namespace ProjectA
{
    partial class AddEvaluation
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblMarks = new System.Windows.Forms.Label();
            this.lblWeightage = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtMarks = new System.Windows.Forms.TextBox();
            this.txtWeightage = new System.Windows.Forms.TextBox();
            this.btnAddEvalutation = new System.Windows.Forms.Button();
            this.dgvEvaluations = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblBack = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvaluations)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(321, 87);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(61, 24);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblMarks
            // 
            this.lblMarks.AutoSize = true;
            this.lblMarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarks.Location = new System.Drawing.Point(321, 143);
            this.lblMarks.Name = "lblMarks";
            this.lblMarks.Size = new System.Drawing.Size(106, 24);
            this.lblMarks.TabIndex = 1;
            this.lblMarks.Text = "Total Marks";
            // 
            // lblWeightage
            // 
            this.lblWeightage.AutoSize = true;
            this.lblWeightage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeightage.Location = new System.Drawing.Point(321, 194);
            this.lblWeightage.Name = "lblWeightage";
            this.lblWeightage.Size = new System.Drawing.Size(147, 24);
            this.lblWeightage.TabIndex = 2;
            this.lblWeightage.Text = "Total Weightage";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(515, 89);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(242, 22);
            this.txtName.TabIndex = 3;
            // 
            // txtMarks
            // 
            this.txtMarks.Location = new System.Drawing.Point(515, 145);
            this.txtMarks.Name = "txtMarks";
            this.txtMarks.Size = new System.Drawing.Size(242, 22);
            this.txtMarks.TabIndex = 4;
            // 
            // txtWeightage
            // 
            this.txtWeightage.Location = new System.Drawing.Point(515, 196);
            this.txtWeightage.Name = "txtWeightage";
            this.txtWeightage.Size = new System.Drawing.Size(242, 22);
            this.txtWeightage.TabIndex = 5;
            // 
            // btnAddEvalutation
            // 
            this.btnAddEvalutation.Location = new System.Drawing.Point(676, 260);
            this.btnAddEvalutation.Name = "btnAddEvalutation";
            this.btnAddEvalutation.Size = new System.Drawing.Size(80, 30);
            this.btnAddEvalutation.TabIndex = 6;
            this.btnAddEvalutation.Text = "Submit";
            this.btnAddEvalutation.UseVisualStyleBackColor = true;
            this.btnAddEvalutation.Click += new System.EventHandler(this.btnAddEvalutation_Click);
            // 
            // dgvEvaluations
            // 
            this.dgvEvaluations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvaluations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.Delete});
            this.dgvEvaluations.Location = new System.Drawing.Point(180, 325);
            this.dgvEvaluations.Name = "dgvEvaluations";
            this.dgvEvaluations.RowTemplate.Height = 24;
            this.dgvEvaluations.Size = new System.Drawing.Size(717, 307);
            this.dgvEvaluations.TabIndex = 7;
            this.dgvEvaluations.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEvaluations_CellContentClick);
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit Data";
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.Location = new System.Drawing.Point(901, 659);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(166, 24);
            this.lblBack.TabIndex = 17;
            this.lblBack.TabStop = true;
            this.lblBack.Text = "Back to Main Page";
            this.lblBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblBack_LinkClicked);
            // 
            // AddEvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 692);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.dgvEvaluations);
            this.Controls.Add(this.btnAddEvalutation);
            this.Controls.Add(this.txtWeightage);
            this.Controls.Add(this.txtMarks);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblWeightage);
            this.Controls.Add(this.lblMarks);
            this.Controls.Add(this.lblName);
            this.Name = "AddEvaluation";
            this.Text = "AddEvaluation";
            this.Load += new System.EventHandler(this.AddEvaluation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvaluations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblMarks;
        private System.Windows.Forms.Label lblWeightage;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtMarks;
        private System.Windows.Forms.TextBox txtWeightage;
        private System.Windows.Forms.Button btnAddEvalutation;
        private System.Windows.Forms.DataGridView dgvEvaluations;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.LinkLabel lblBack;
    }
}