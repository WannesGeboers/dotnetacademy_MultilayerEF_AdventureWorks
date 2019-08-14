namespace AdventureWorksWinForms.UI
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SumOfTotalDue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnHigher = new System.Windows.Forms.Button();
            this.btnLower = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstName,
            this.LastName,
            this.AccountNumber,
            this.SumOfTotalDue});
            this.dataGridView1.Location = new System.Drawing.Point(108, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(1715, 908);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.MinimumWidth = 12;
            this.FirstName.Name = "FirstName";
            this.FirstName.Width = 250;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "LastName";
            this.LastName.MinimumWidth = 12;
            this.LastName.Name = "LastName";
            this.LastName.Width = 250;
            // 
            // AccountNumber
            // 
            this.AccountNumber.DataPropertyName = "AccountNumber";
            this.AccountNumber.HeaderText = "AccountNumber";
            this.AccountNumber.MinimumWidth = 12;
            this.AccountNumber.Name = "AccountNumber";
            this.AccountNumber.Width = 250;
            // 
            // SumOfTotalDue
            // 
            this.SumOfTotalDue.DataPropertyName = "SumOfTotalDue";
            this.SumOfTotalDue.HeaderText = "SumOfTotalDue";
            this.SumOfTotalDue.MinimumWidth = 12;
            this.SumOfTotalDue.Name = "SumOfTotalDue";
            this.SumOfTotalDue.Width = 250;
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(1862, 106);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(218, 86);
            this.btnAll.TabIndex = 1;
            this.btnAll.Text = "View All";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnHigher
            // 
            this.btnHigher.Location = new System.Drawing.Point(1862, 221);
            this.btnHigher.Name = "btnHigher";
            this.btnHigher.Size = new System.Drawing.Size(218, 86);
            this.btnHigher.TabIndex = 2;
            this.btnHigher.Text = "Higher then SumOfTotalDue";
            this.btnHigher.UseVisualStyleBackColor = true;
            this.btnHigher.Click += new System.EventHandler(this.BtnHigher_Click);
            // 
            // btnLower
            // 
            this.btnLower.Location = new System.Drawing.Point(1862, 342);
            this.btnLower.Name = "btnLower";
            this.btnLower.Size = new System.Drawing.Size(218, 86);
            this.btnLower.TabIndex = 3;
            this.btnLower.Text = "Lower than SumOfTotalDue";
            this.btnLower.UseVisualStyleBackColor = true;
            this.btnLower.Click += new System.EventHandler(this.BtnLower_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2124, 1142);
            this.Controls.Add(this.btnLower);
            this.Controls.Add(this.btnHigher);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn SumOfTotalDue;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnHigher;
        private System.Windows.Forms.Button btnLower;
    }
}

