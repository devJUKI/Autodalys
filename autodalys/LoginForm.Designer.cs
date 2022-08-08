namespace autodalys
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.login_client = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.login_employee = new System.Windows.Forms.Button();
            this.loginData = new System.Windows.Forms.TextBox();
            this.loginTypeLabel = new System.Windows.Forms.Label();
            this.clientDebugLogin = new System.Windows.Forms.Button();
            this.employeeDebugLogin = new System.Windows.Forms.Button();
            this.createClient = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // login_client
            // 
            this.login_client.Location = new System.Drawing.Point(66, 103);
            this.login_client.Name = "login_client";
            this.login_client.Size = new System.Drawing.Size(150, 50);
            this.login_client.TabIndex = 0;
            this.login_client.Text = "Prisijungti (Klientas)";
            this.login_client.UseVisualStyleBackColor = true;
            this.login_client.Click += new System.EventHandler(this.clientLogin_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(99, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "AUTO DALYS";
            // 
            // login_employee
            // 
            this.login_employee.Location = new System.Drawing.Point(66, 47);
            this.login_employee.Name = "login_employee";
            this.login_employee.Size = new System.Drawing.Size(150, 50);
            this.login_employee.TabIndex = 2;
            this.login_employee.Text = "Prisijungti (Darbuotojas)";
            this.login_employee.UseVisualStyleBackColor = true;
            this.login_employee.Click += new System.EventHandler(this.employeeLogin_Click);
            // 
            // loginData
            // 
            this.loginData.Location = new System.Drawing.Point(66, 249);
            this.loginData.Name = "loginData";
            this.loginData.Size = new System.Drawing.Size(135, 22);
            this.loginData.TabIndex = 3;
            this.loginData.Visible = false;
            this.loginData.TextChanged += new System.EventHandler(this.OnLoginDataChanged);
            // 
            // loginTypeLabel
            // 
            this.loginTypeLabel.AutoSize = true;
            this.loginTypeLabel.Location = new System.Drawing.Point(63, 230);
            this.loginTypeLabel.Name = "loginTypeLabel";
            this.loginTypeLabel.Size = new System.Drawing.Size(88, 16);
            this.loginTypeLabel.TabIndex = 4;
            this.loginTypeLabel.Text = "Vidinis kodas";
            this.loginTypeLabel.Visible = false;
            // 
            // clientDebugLogin
            // 
            this.clientDebugLogin.Location = new System.Drawing.Point(263, 103);
            this.clientDebugLogin.Name = "clientDebugLogin";
            this.clientDebugLogin.Size = new System.Drawing.Size(150, 50);
            this.clientDebugLogin.TabIndex = 5;
            this.clientDebugLogin.Text = "Debug Login (Client)";
            this.clientDebugLogin.UseVisualStyleBackColor = true;
            this.clientDebugLogin.Click += new System.EventHandler(this.ClientDebugLogin);
            // 
            // employeeDebugLogin
            // 
            this.employeeDebugLogin.Location = new System.Drawing.Point(263, 47);
            this.employeeDebugLogin.Name = "employeeDebugLogin";
            this.employeeDebugLogin.Size = new System.Drawing.Size(150, 50);
            this.employeeDebugLogin.TabIndex = 6;
            this.employeeDebugLogin.Text = "Debug Login (Employee)";
            this.employeeDebugLogin.UseVisualStyleBackColor = true;
            this.employeeDebugLogin.Click += new System.EventHandler(this.employeeDebugLogin_Click);
            // 
            // createClient
            // 
            this.createClient.Location = new System.Drawing.Point(66, 159);
            this.createClient.Name = "createClient";
            this.createClient.Size = new System.Drawing.Size(150, 49);
            this.createClient.TabIndex = 7;
            this.createClient.Text = "Registruotis (Klientas)";
            this.createClient.UseVisualStyleBackColor = true;
            this.createClient.Click += new System.EventHandler(this.createClient_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.Location = new System.Drawing.Point(316, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "DEBUG";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 253);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.createClient);
            this.Controls.Add(this.employeeDebugLogin);
            this.Controls.Add(this.clientDebugLogin);
            this.Controls.Add(this.loginTypeLabel);
            this.Controls.Add(this.loginData);
            this.Controls.Add(this.login_employee);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.login_client);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AUTODALYS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login_client;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button login_employee;
        private System.Windows.Forms.TextBox loginData;
        private System.Windows.Forms.Label loginTypeLabel;
        private System.Windows.Forms.Button clientDebugLogin;
        private System.Windows.Forms.Button employeeDebugLogin;
        private System.Windows.Forms.Button createClient;
        private System.Windows.Forms.Label label2;
    }
}

