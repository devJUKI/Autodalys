namespace autodalys
{
    partial class CreateClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateClientForm));
            this.createClient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.birthDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.personalCode = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.surname = new System.Windows.Forms.TextBox();
            this.phoneNr = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.NumericUpDown();
            this.email = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.age)).BeginInit();
            this.SuspendLayout();
            // 
            // createClient
            // 
            this.createClient.Location = new System.Drawing.Point(91, 261);
            this.createClient.Name = "createClient";
            this.createClient.Size = new System.Drawing.Size(150, 50);
            this.createClient.TabIndex = 3;
            this.createClient.Text = "Sukurti";
            this.createClient.UseVisualStyleBackColor = true;
            this.createClient.Click += new System.EventHandler(this.createClient_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Asmens kodas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Vardas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pavardė";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Telefono nr.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "El. paštas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Amžius";
            // 
            // birthDate
            // 
            this.birthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthDate.Location = new System.Drawing.Point(163, 219);
            this.birthDate.Name = "birthDate";
            this.birthDate.Size = new System.Drawing.Size(157, 22);
            this.birthDate.TabIndex = 10;
            this.birthDate.Value = new System.DateTime(2022, 4, 13, 16, 2, 24, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Gimimo data";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(115, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Sukurti vartotoją";
            // 
            // personalCode
            // 
            this.personalCode.Location = new System.Drawing.Point(163, 51);
            this.personalCode.Name = "personalCode";
            this.personalCode.Size = new System.Drawing.Size(157, 22);
            this.personalCode.TabIndex = 13;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(163, 79);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(157, 22);
            this.name.TabIndex = 14;
            // 
            // surname
            // 
            this.surname.Location = new System.Drawing.Point(163, 107);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(157, 22);
            this.surname.TabIndex = 15;
            // 
            // phoneNr
            // 
            this.phoneNr.Location = new System.Drawing.Point(163, 135);
            this.phoneNr.Name = "phoneNr";
            this.phoneNr.Size = new System.Drawing.Size(157, 22);
            this.phoneNr.TabIndex = 16;
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(163, 191);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(157, 22);
            this.age.TabIndex = 17;
            this.age.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(163, 163);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(157, 22);
            this.email.TabIndex = 18;
            // 
            // CreateClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 323);
            this.Controls.Add(this.email);
            this.Controls.Add(this.age);
            this.Controls.Add(this.phoneNr);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.name);
            this.Controls.Add(this.personalCode);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.birthDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createClient);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AUTODALYS";
            ((System.ComponentModel.ISupportInitialize)(this.age)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker birthDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox personalCode;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.TextBox phoneNr;
        private System.Windows.Forms.NumericUpDown age;
        private System.Windows.Forms.TextBox email;
    }
}