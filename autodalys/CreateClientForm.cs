using autodalys.Controllers;
using autodalys.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autodalys
{
    public partial class CreateClientForm : Form
    {
        public CreateClientForm() {
            InitializeComponent();
        }

        private void createClient_Click(object sender, EventArgs e) {
            if (KlientasController.Find(long.Parse(personalCode.Text)) != null)
                return;

            KlientasController.CreateClient(new Klientas {
                AsmensKodas = long.Parse(personalCode.Text),
                Vardas = name.Text,
                Pavarde = surname.Text,
                TelefonoNr = phoneNr.Text,
                ElPastas = email.Text,
                Amzius = (int)age.Value,
                GimimoData = DateTime.Now.Date
            });

            Close();
        }
    }
}
