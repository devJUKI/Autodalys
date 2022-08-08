namespace autodalys
{
    partial class CreatePartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatePartForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.categoryDropDown = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.partName = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.vin = new System.Windows.Forms.TextBox();
            this.createPart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pridėti detalę";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Detalės pavadinimas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kaina";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kategorija";
            // 
            // categoryDropDown
            // 
            this.categoryDropDown.FormattingEnabled = true;
            this.categoryDropDown.Location = new System.Drawing.Point(191, 113);
            this.categoryDropDown.Name = "categoryDropDown";
            this.categoryDropDown.Size = new System.Drawing.Size(225, 24);
            this.categoryDropDown.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "VIN";
            // 
            // partName
            // 
            this.partName.Location = new System.Drawing.Point(191, 57);
            this.partName.Name = "partName";
            this.partName.Size = new System.Drawing.Size(225, 22);
            this.partName.TabIndex = 6;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(191, 85);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(225, 22);
            this.price.TabIndex = 7;
            // 
            // vin
            // 
            this.vin.Location = new System.Drawing.Point(191, 143);
            this.vin.Name = "vin";
            this.vin.Size = new System.Drawing.Size(225, 22);
            this.vin.TabIndex = 8;
            // 
            // createPart
            // 
            this.createPart.Location = new System.Drawing.Point(143, 201);
            this.createPart.Name = "createPart";
            this.createPart.Size = new System.Drawing.Size(150, 50);
            this.createPart.TabIndex = 10;
            this.createPart.Text = "Pridėti";
            this.createPart.UseVisualStyleBackColor = true;
            this.createPart.Click += new System.EventHandler(this.createPart_Click);
            // 
            // CreatePartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 263);
            this.Controls.Add(this.createPart);
            this.Controls.Add(this.vin);
            this.Controls.Add(this.price);
            this.Controls.Add(this.partName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.categoryDropDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreatePartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AUTODALYS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox categoryDropDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox partName;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox vin;
        private System.Windows.Forms.Button createPart;
    }
}