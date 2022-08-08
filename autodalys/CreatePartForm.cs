using autodalys.Controllers;
using autodalys.Models;
using System;
using System.Windows.Forms;

namespace autodalys
{
    public partial class CreatePartForm : Form
    {
        public CreatePartForm() {
            InitializeComponent();
            InitializeUI();
        }

        private void InitializeUI() {
            KategorijaController.GetCategories().ForEach(
                x => categoryDropDown.Items.Add(x.Pavadinimas));
        }

        private void createPart_Click(object sender, EventArgs e) {
            if (KategorijaController.GetCategory(categoryDropDown.Text) == null) {
                KategorijaController.CreateCategory(categoryDropDown.Text);
            }

            Detale detale = new Detale {
                Pavadinimas = partName.Text,
                Kaina = decimal.Parse(price.Text.Replace('.', ',')),
                KategorijosId = KategorijaController.GetCategory(categoryDropDown.Text).Id,
                AutomobilioVin = vin.Text
            };

            DetaleController.CreatePart(detale);
            Close();
        }
    }
}
