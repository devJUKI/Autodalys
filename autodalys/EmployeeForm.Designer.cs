namespace autodalys
{
    partial class EmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            this.buyCar = new System.Windows.Forms.Button();
            this.createPart = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.greetingsLabel = new System.Windows.Forms.Label();
            this.reportButton = new System.Windows.Forms.Button();
            this.reportLd3Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buyCar
            // 
            this.buyCar.Location = new System.Drawing.Point(103, 129);
            this.buyCar.Name = "buyCar";
            this.buyCar.Size = new System.Drawing.Size(150, 50);
            this.buyCar.TabIndex = 4;
            this.buyCar.Text = "Automobilio pirkimas";
            this.buyCar.UseVisualStyleBackColor = true;
            this.buyCar.Click += new System.EventHandler(this.buyCar_Click);
            // 
            // createPart
            // 
            this.createPart.Location = new System.Drawing.Point(103, 73);
            this.createPart.Name = "createPart";
            this.createPart.Size = new System.Drawing.Size(150, 50);
            this.createPart.TabIndex = 5;
            this.createPart.Text = "Detalės įrašymas";
            this.createPart.UseVisualStyleBackColor = true;
            this.createPart.Click += new System.EventHandler(this.createPart_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(30, 30);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "<";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // greetingsLabel
            // 
            this.greetingsLabel.Location = new System.Drawing.Point(48, 16);
            this.greetingsLabel.Name = "greetingsLabel";
            this.greetingsLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.greetingsLabel.Size = new System.Drawing.Size(297, 23);
            this.greetingsLabel.TabIndex = 7;
            this.greetingsLabel.Text = "Sveiki, Vardas Pavardė";
            this.greetingsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // reportButton
            // 
            this.reportButton.Location = new System.Drawing.Point(103, 185);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(150, 50);
            this.reportButton.TabIndex = 8;
            this.reportButton.Text = "Raportai";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // reportLd3Button
            // 
            this.reportLd3Button.Location = new System.Drawing.Point(103, 241);
            this.reportLd3Button.Name = "reportLd3Button";
            this.reportLd3Button.Size = new System.Drawing.Size(150, 50);
            this.reportLd3Button.TabIndex = 9;
            this.reportLd3Button.Text = "Ataskaita (LD3)";
            this.reportLd3Button.UseVisualStyleBackColor = true;
            this.reportLd3Button.Click += new System.EventHandler(this.reportLd3Button_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 308);
            this.Controls.Add(this.reportLd3Button);
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.greetingsLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.createPart);
            this.Controls.Add(this.buyCar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AUTODALYS";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buyCar;
        private System.Windows.Forms.Button createPart;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label greetingsLabel;
        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.Button reportLd3Button;
    }
}