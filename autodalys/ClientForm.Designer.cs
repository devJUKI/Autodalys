namespace autodalys
{
    partial class ClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            this.backButton = new System.Windows.Forms.Button();
            this.greetingsLabel = new System.Windows.Forms.Label();
            this.makesDropdown = new System.Windows.Forms.ComboBox();
            this.modelsDropdown = new System.Windows.Forms.ComboBox();
            this.categoriesDropdown = new System.Windows.Forms.ComboBox();
            this.partsListBox = new System.Windows.Forms.CheckedListBox();
            this.cartListBox = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.makeOrder = new System.Windows.Forms.Button();
            this.toCart = new System.Windows.Forms.Button();
            this.fromCart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(30, 30);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "<";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // greetingsLabel
            // 
            this.greetingsLabel.Location = new System.Drawing.Point(48, 16);
            this.greetingsLabel.Name = "greetingsLabel";
            this.greetingsLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.greetingsLabel.Size = new System.Drawing.Size(552, 23);
            this.greetingsLabel.TabIndex = 1;
            this.greetingsLabel.Text = "Sveiki, Vardas Pavardė";
            this.greetingsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // makesDropdown
            // 
            this.makesDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.makesDropdown.FormattingEnabled = true;
            this.makesDropdown.Location = new System.Drawing.Point(12, 48);
            this.makesDropdown.Name = "makesDropdown";
            this.makesDropdown.Size = new System.Drawing.Size(193, 24);
            this.makesDropdown.TabIndex = 2;
            this.makesDropdown.SelectedIndexChanged += new System.EventHandler(this.MakesOnSelectedIndexChanged);
            // 
            // modelsDropdown
            // 
            this.modelsDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modelsDropdown.Enabled = false;
            this.modelsDropdown.FormattingEnabled = true;
            this.modelsDropdown.Location = new System.Drawing.Point(211, 48);
            this.modelsDropdown.Name = "modelsDropdown";
            this.modelsDropdown.Size = new System.Drawing.Size(192, 24);
            this.modelsDropdown.TabIndex = 3;
            this.modelsDropdown.SelectedIndexChanged += new System.EventHandler(this.ModelsOnSelectedIndexChanged);
            // 
            // categoriesDropdown
            // 
            this.categoriesDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoriesDropdown.Enabled = false;
            this.categoriesDropdown.FormattingEnabled = true;
            this.categoriesDropdown.Location = new System.Drawing.Point(409, 48);
            this.categoriesDropdown.Name = "categoriesDropdown";
            this.categoriesDropdown.Size = new System.Drawing.Size(192, 24);
            this.categoriesDropdown.TabIndex = 4;
            this.categoriesDropdown.SelectedIndexChanged += new System.EventHandler(this.OnCategoriesSelectedIndexChanged);
            // 
            // partsListBox
            // 
            this.partsListBox.FormattingEnabled = true;
            this.partsListBox.Location = new System.Drawing.Point(11, 106);
            this.partsListBox.Name = "partsListBox";
            this.partsListBox.Size = new System.Drawing.Size(290, 208);
            this.partsListBox.TabIndex = 6;
            // 
            // cartListBox
            // 
            this.cartListBox.FormattingEnabled = true;
            this.cartListBox.Location = new System.Drawing.Point(310, 106);
            this.cartListBox.Name = "cartListBox";
            this.cartListBox.Size = new System.Drawing.Size(290, 208);
            this.cartListBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Prekės";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Pirkinių krepšelis";
            // 
            // makeOrder
            // 
            this.makeOrder.Location = new System.Drawing.Point(231, 320);
            this.makeOrder.Name = "makeOrder";
            this.makeOrder.Size = new System.Drawing.Size(150, 41);
            this.makeOrder.TabIndex = 10;
            this.makeOrder.Text = "Užsakyti";
            this.makeOrder.UseVisualStyleBackColor = true;
            this.makeOrder.Click += new System.EventHandler(this.makeOrder_Click);
            // 
            // toCart
            // 
            this.toCart.Location = new System.Drawing.Point(12, 320);
            this.toCart.Name = "toCart";
            this.toCart.Size = new System.Drawing.Size(150, 41);
            this.toCart.TabIndex = 11;
            this.toCart.Text = "Į krepšelį";
            this.toCart.UseVisualStyleBackColor = true;
            this.toCart.Click += new System.EventHandler(this.toCart_Click);
            // 
            // fromCart
            // 
            this.fromCart.Location = new System.Drawing.Point(451, 320);
            this.fromCart.Name = "fromCart";
            this.fromCart.Size = new System.Drawing.Size(150, 41);
            this.fromCart.TabIndex = 12;
            this.fromCart.Text = "Išimti iš krepšelio";
            this.fromCart.UseVisualStyleBackColor = true;
            this.fromCart.Click += new System.EventHandler(this.fromCart_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 373);
            this.Controls.Add(this.fromCart);
            this.Controls.Add(this.toCart);
            this.Controls.Add(this.makeOrder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cartListBox);
            this.Controls.Add(this.partsListBox);
            this.Controls.Add(this.categoriesDropdown);
            this.Controls.Add(this.modelsDropdown);
            this.Controls.Add(this.makesDropdown);
            this.Controls.Add(this.greetingsLabel);
            this.Controls.Add(this.backButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AUTODALYS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label greetingsLabel;
        private System.Windows.Forms.ComboBox makesDropdown;
        private System.Windows.Forms.ComboBox modelsDropdown;
        private System.Windows.Forms.ComboBox categoriesDropdown;
        private System.Windows.Forms.CheckedListBox partsListBox;
        private System.Windows.Forms.CheckedListBox cartListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button makeOrder;
        private System.Windows.Forms.Button toCart;
        private System.Windows.Forms.Button fromCart;
    }
}