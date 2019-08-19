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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalDueEx = new System.Windows.Forms.Label();
            this.lblRows = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstName,
            this.LastName,
            this.AccountNumber,
            this.SumOfTotalDue});
            this.dataGridView1.Location = new System.Drawing.Point(91, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
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
            this.FirstName.Width = 199;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "LastName";
            this.LastName.MinimumWidth = 12;
            this.LastName.Name = "LastName";
            this.LastName.Width = 198;
            // 
            // AccountNumber
            // 
            this.AccountNumber.DataPropertyName = "AccountNumber";
            this.AccountNumber.HeaderText = "AccountNumber";
            this.AccountNumber.MinimumWidth = 12;
            this.AccountNumber.Name = "AccountNumber";
            this.AccountNumber.Width = 272;
            // 
            // SumOfTotalDue
            // 
            this.SumOfTotalDue.DataPropertyName = "SumOfTotalDue";
            this.SumOfTotalDue.HeaderText = "SumOfTotalDue";
            this.SumOfTotalDue.MinimumWidth = 12;
            this.SumOfTotalDue.Name = "SumOfTotalDue";
            this.SumOfTotalDue.Width = 273;
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
            this.btnHigher.Text = "Higher then Average";
            this.btnHigher.UseVisualStyleBackColor = true;
            this.btnHigher.Click += new System.EventHandler(this.BtnHigher_Click);
            // 
            // btnLower
            // 
            this.btnLower.Location = new System.Drawing.Point(1862, 342);
            this.btnLower.Name = "btnLower";
            this.btnLower.Size = new System.Drawing.Size(218, 86);
            this.btnLower.TabIndex = 3;
            this.btnLower.Text = "Lower than Average";
            this.btnLower.UseVisualStyleBackColor = true;
            this.btnLower.Click += new System.EventHandler(this.BtnLower_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1862, 476);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(218, 38);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1862, 554);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(218, 39);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1862, 627);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 86);
            this.button1.TabIndex = 6;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(456, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(819, 69);
            this.label1.TabIndex = 7;
            this.label1.Text = "AdventureWorks: Customers";
            // 
            // lblTotalDueEx
            // 
            this.lblTotalDueEx.Location = new System.Drawing.Point(1856, 735);
            this.lblTotalDueEx.Name = "lblTotalDueEx";
            this.lblTotalDueEx.Size = new System.Drawing.Size(224, 146);
            this.lblTotalDueEx.TabIndex = 8;
            this.lblTotalDueEx.Text = "< > = [number] ex. <666";
            this.lblTotalDueEx.Visible = false;
            this.lblTotalDueEx.Click += new System.EventHandler(this.Label2_Click);
            // 
            // lblRows
            // 
            this.lblRows.AutoSize = true;
            this.lblRows.Location = new System.Drawing.Point(741, 1065);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(82, 32);
            this.lblRows.TabIndex = 9;
            this.lblRows.Text = "rows:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2100, 1167);
            this.Controls.Add(this.lblRows);
            this.Controls.Add(this.lblTotalDueEx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnLower);
            this.Controls.Add(this.btnHigher);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalDueEx;
        private System.Windows.Forms.Label lblRows;
    }
}

