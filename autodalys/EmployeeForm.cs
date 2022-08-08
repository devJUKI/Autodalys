using autodalys.Models;
using System;
using System.Windows.Forms;

namespace autodalys
{
    public partial class EmployeeForm : Form
    {
        private Darbuotojas employee;

        public EmployeeForm(Darbuotojas employee) {
            InitializeComponent();

            this.employee = employee;
            greetingsLabel.Text = $"Sveiki, {employee.Vardas} {employee.Pavarde}";
        }

        private void buyCar_Click(object sender, EventArgs e) {
            new BuyCarForm(employee).Show();
        }

        private void createPart_Click(object sender, EventArgs e) {
            new CreatePartForm().Show();
        }

        private void backButton_Click(object sender, EventArgs e) {
            Close();
            new LoginForm().Show();
        }

        private void reportButton_Click(object sender, EventArgs e) {
            new ReportsForm().Show();
        }

        private void reportLd3Button_Click(object sender, EventArgs e) {
            new ReportLD3Form().Show();
        }
    }
}
