using autodalys.Controllers;
using autodalys.Models;
using System;
using System.Windows.Forms;

namespace autodalys
{
    public partial class LoginForm : Form
    {
        private Role role;

        public LoginForm() {
            InitializeComponent();
        }

        private void employeeLogin_Click(object sender, EventArgs e) {
            loginTypeLabel.Text = "Vidinis kodas";
            role = Role.Employee;
            ShowLoginSection(true);
        }

        private void clientLogin_Click(object sender, EventArgs e) {
            loginTypeLabel.Text = "Asmens kodas";
            role = Role.Client;
            ShowLoginSection(true);
        }

        private void ShowLoginSection(bool show) {
            Size = new System.Drawing.Size(Size.Width, show ? 350 : 300);
            loginTypeLabel.Visible = show;
            loginData.Visible = show;
        }

        private void OnLoginDataChanged(object sender, EventArgs e) {
            if (role == Role.Client && loginData.Text.Length == 11) {
                Klientas klientas = KlientasController.Find(long.Parse(loginData.Text));
                if (klientas != null) {
                    new ClientForm(klientas).Show();
                    Hide();
                }
                else {
                    Console.WriteLine("Klientas nerastas duomenų bazėje");
                }
            }
            else if (role == Role.Employee && loginData.Text.Length == 5) {
                Darbuotojas darbuotojas = DarbuotojasController.Find(loginData.Text);
                if (darbuotojas != null) {
                    new EmployeeForm(darbuotojas).Show();
                    Hide();
                }
                else {
                    Console.WriteLine("Darbuotojas nerastas duomenų bazėje");
                }
            }
        }

        private void ClientDebugLogin(object sender, EventArgs e) {
            loginData.Text = "26116443299";
        }

        private void createClient_Click(object sender, EventArgs e) {
            new CreateClientForm().Show();
        }

        private void employeeDebugLogin_Click(object sender, EventArgs e) {
            loginData.Text = "F5296";
        }
    }

    public enum Role
    {
        Employee,
        Client
    }
}
