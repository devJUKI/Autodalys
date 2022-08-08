namespace autodalys
{
    partial class ReportLD3Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportLD3Form));
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.getReportButton = new System.Windows.Forms.Button();
            this.dataMin = new System.Windows.Forms.DateTimePicker();
            this.dataMax = new System.Windows.Forms.DateTimePicker();
            this.ridaMin = new System.Windows.Forms.NumericUpDown();
            this.ridaMax = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.ridaMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ridaMax)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Sutarčių data iki";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Sutarčių data nuo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Maksimali rida";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Minimali rida";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Užpildykite sutarties filtrų duomenis";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 14);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(30, 30);
            this.backButton.TabIndex = 12;
            this.backButton.Text = "<";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // getReportButton
            // 
            this.getReportButton.Location = new System.Drawing.Point(263, 195);
            this.getReportButton.Name = "getReportButton";
            this.getReportButton.Size = new System.Drawing.Size(135, 35);
            this.getReportButton.TabIndex = 22;
            this.getReportButton.Text = "Gauti ataskaitą";
            this.getReportButton.UseVisualStyleBackColor = true;
            this.getReportButton.Click += new System.EventHandler(this.getReportButton_Click);
            // 
            // dataMin
            // 
            this.dataMin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataMin.Location = new System.Drawing.Point(197, 125);
            this.dataMin.Name = "dataMin";
            this.dataMin.Size = new System.Drawing.Size(200, 22);
            this.dataMin.TabIndex = 23;
            // 
            // dataMax
            // 
            this.dataMax.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataMax.Location = new System.Drawing.Point(197, 153);
            this.dataMax.Name = "dataMax";
            this.dataMax.Size = new System.Drawing.Size(200, 22);
            this.dataMax.TabIndex = 24;
            // 
            // ridaMin
            // 
            this.ridaMin.Location = new System.Drawing.Point(197, 70);
            this.ridaMin.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.ridaMin.Name = "ridaMin";
            this.ridaMin.Size = new System.Drawing.Size(200, 22);
            this.ridaMin.TabIndex = 25;
            // 
            // ridaMax
            // 
            this.ridaMax.Location = new System.Drawing.Point(197, 98);
            this.ridaMax.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.ridaMax.Name = "ridaMax";
            this.ridaMax.Size = new System.Drawing.Size(200, 22);
            this.ridaMax.TabIndex = 26;
            // 
            // ReportLD3Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 242);
            this.Controls.Add(this.ridaMax);
            this.Controls.Add(this.ridaMin);
            this.Controls.Add(this.dataMax);
            this.Controls.Add(this.dataMin);
            this.Controls.Add(this.getReportButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReportLD3Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AUTODALYS";
            ((System.ComponentModel.ISupportInitialize)(this.ridaMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ridaMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button getReportButton;
        private System.Windows.Forms.DateTimePicker dataMin;
        private System.Windows.Forms.DateTimePicker dataMax;
        private System.Windows.Forms.NumericUpDown ridaMin;
        private System.Windows.Forms.NumericUpDown ridaMax;
    }
}