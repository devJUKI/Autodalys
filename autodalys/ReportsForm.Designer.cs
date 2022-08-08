namespace autodalys
{
    partial class ReportsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportsForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteEntry = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.changeEntry = new System.Windows.Forms.Button();
            this.purchaseCount = new System.Windows.Forms.TextBox();
            this.moneySpent = new System.Windows.Forms.TextBox();
            this.employeeCode = new System.Windows.Forms.TextBox();
            this.month = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.month)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(603, 239);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.OnGridSelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "RAPORTAI";
            // 
            // deleteEntry
            // 
            this.deleteEntry.Location = new System.Drawing.Point(163, 341);
            this.deleteEntry.Name = "deleteEntry";
            this.deleteEntry.Size = new System.Drawing.Size(150, 54);
            this.deleteEntry.TabIndex = 9;
            this.deleteEntry.Text = "Ištrinti";
            this.deleteEntry.UseVisualStyleBackColor = true;
            this.deleteEntry.Click += new System.EventHandler(this.deleteEntry_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 12);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(30, 30);
            this.BackButton.TabIndex = 10;
            this.BackButton.Text = "<";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // changeEntry
            // 
            this.changeEntry.Location = new System.Drawing.Point(319, 341);
            this.changeEntry.Name = "changeEntry";
            this.changeEntry.Size = new System.Drawing.Size(150, 54);
            this.changeEntry.TabIndex = 11;
            this.changeEntry.Text = "Keisti";
            this.changeEntry.UseVisualStyleBackColor = true;
            this.changeEntry.Click += new System.EventHandler(this.changeEntry_Click);
            // 
            // purchaseCount
            // 
            this.purchaseCount.Location = new System.Drawing.Point(148, 293);
            this.purchaseCount.Name = "purchaseCount";
            this.purchaseCount.Size = new System.Drawing.Size(100, 22);
            this.purchaseCount.TabIndex = 12;
            // 
            // moneySpent
            // 
            this.moneySpent.Location = new System.Drawing.Point(254, 293);
            this.moneySpent.Name = "moneySpent";
            this.moneySpent.Size = new System.Drawing.Size(100, 22);
            this.moneySpent.TabIndex = 13;
            // 
            // employeeCode
            // 
            this.employeeCode.Location = new System.Drawing.Point(469, 293);
            this.employeeCode.Name = "employeeCode";
            this.employeeCode.Size = new System.Drawing.Size(100, 22);
            this.employeeCode.TabIndex = 14;
            // 
            // month
            // 
            this.month.Location = new System.Drawing.Point(360, 293);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(103, 22);
            this.month.TabIndex = 15;
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 413);
            this.Controls.Add(this.month);
            this.Controls.Add(this.employeeCode);
            this.Controls.Add(this.moneySpent);
            this.Controls.Add(this.purchaseCount);
            this.Controls.Add(this.changeEntry);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.deleteEntry);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReportsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AUTODALYS";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.month)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteEntry;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button changeEntry;
        private System.Windows.Forms.TextBox purchaseCount;
        private System.Windows.Forms.TextBox moneySpent;
        private System.Windows.Forms.TextBox employeeCode;
        private System.Windows.Forms.NumericUpDown month;
    }
}