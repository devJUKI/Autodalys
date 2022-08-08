namespace autodalys {
    partial class OrderForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.backButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.townTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.totalPrice = new System.Windows.Forms.Label();
            this.streetTB = new System.Windows.Forms.TextBox();
            this.houseNrTB = new System.Windows.Forms.TextBox();
            this.zipCodeTB = new System.Windows.Forms.TextBox();
            this.confirmOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(30, 30);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "<";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Užpildykite užsakymo duomenis";
            // 
            // townTB
            // 
            this.townTB.Location = new System.Drawing.Point(191, 67);
            this.townTB.Name = "townTB";
            this.townTB.Size = new System.Drawing.Size(201, 22);
            this.townTB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Miestas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Gatvė";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Namo nr.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Pašto kodas";
            // 
            // totalPrice
            // 
            this.totalPrice.Location = new System.Drawing.Point(191, 190);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.Size = new System.Drawing.Size(201, 16);
            this.totalPrice.TabIndex = 8;
            this.totalPrice.Text = "Kaina viso: 0.00";
            this.totalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // streetTB
            // 
            this.streetTB.Location = new System.Drawing.Point(191, 95);
            this.streetTB.Name = "streetTB";
            this.streetTB.Size = new System.Drawing.Size(201, 22);
            this.streetTB.TabIndex = 9;
            // 
            // houseNrTB
            // 
            this.houseNrTB.Location = new System.Drawing.Point(191, 123);
            this.houseNrTB.Name = "houseNrTB";
            this.houseNrTB.Size = new System.Drawing.Size(201, 22);
            this.houseNrTB.TabIndex = 10;
            // 
            // zipCodeTB
            // 
            this.zipCodeTB.Location = new System.Drawing.Point(191, 151);
            this.zipCodeTB.Name = "zipCodeTB";
            this.zipCodeTB.Size = new System.Drawing.Size(201, 22);
            this.zipCodeTB.TabIndex = 11;
            // 
            // confirmOrder
            // 
            this.confirmOrder.Location = new System.Drawing.Point(296, 220);
            this.confirmOrder.Name = "confirmOrder";
            this.confirmOrder.Size = new System.Drawing.Size(96, 35);
            this.confirmOrder.TabIndex = 12;
            this.confirmOrder.Text = "Patvirtinti";
            this.confirmOrder.UseVisualStyleBackColor = true;
            this.confirmOrder.Click += new System.EventHandler(this.confirmOrder_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 270);
            this.Controls.Add(this.confirmOrder);
            this.Controls.Add(this.zipCodeTB);
            this.Controls.Add(this.houseNrTB);
            this.Controls.Add(this.streetTB);
            this.Controls.Add(this.totalPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.townTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AUTODALYS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox townTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label totalPrice;
        private System.Windows.Forms.TextBox streetTB;
        private System.Windows.Forms.TextBox houseNrTB;
        private System.Windows.Forms.TextBox zipCodeTB;
        private System.Windows.Forms.Button confirmOrder;
    }
}