using autodalys.Controllers;
using autodalys.Models;
using autodalys.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace autodalys {
    public partial class ClientForm : Form {
        private Klientas client;
        private int selectedCategoryIndex;
        private List<Detale> parts;

        public ClientForm(Klientas client) {
            InitializeComponent();
            this.client = client;

            greetingsLabel.Text = $"Sveiki, {client.Vardas} {client.Pavarde}";
            List<Marke> makes = MarkeController.GetMakes();
            string[] makeNames = makes.Select(x => x.Pavadinimas).ToArray();
            HandleDropdown(makesDropdown, "Markės", makeNames);
        }

        private void backButton_Click(object sender, EventArgs e) {
            Close();
            new LoginForm().Show();
        }

        private void MakesOnSelectedIndexChanged(object sender, EventArgs e) {
            if (makesDropdown.SelectedIndex <= 0) {
                DisableDropdown(modelsDropdown);
                return;
            }

            int makeId = makesDropdown.SelectedIndex;
            List<Modelis> models = ModelisController.GetModels(makeId);
            string[] modelNames = models.Select(x => x.Pavadinimas).ToArray();
            HandleDropdown(modelsDropdown, "Modelis", modelNames);
        }

        private void ModelsOnSelectedIndexChanged(object sender, EventArgs e) {
            if (modelsDropdown.SelectedIndex <= 0) {
                DisableDropdown(categoriesDropdown);
                return;
            }

            List<Kategorija> categories = KategorijaController.GetCategories();
            string[] categoriesNames = categories.Select(x => x.Pavadinimas).ToArray();
            HandleDropdown(categoriesDropdown, "Kategorija", categoriesNames);
        }

        private void HandleDropdown(ComboBox dropdown, string firstEntry, object[] data) {
            dropdown.Items.Clear();
            dropdown.Items.Add(firstEntry);
            dropdown.Items.AddRange(data);
            dropdown.SelectedIndex = 0;
            dropdown.Enabled = true;
        }

        private void DisableDropdown(ComboBox comboBox) {
            comboBox.SelectedIndex = -1;
            comboBox.Items.Clear();
            comboBox.Enabled = false;
        }

        private void OnCategoriesSelectedIndexChanged(object sender, EventArgs e) {
            partsListBox.Items.Clear();

            if (categoriesDropdown.SelectedIndex <= 0)
                return;

            selectedCategoryIndex = categoriesDropdown.SelectedIndex;
            int modelId = modelsDropdown.SelectedIndex;
            parts = DetaleController.GetAvailableParts(selectedCategoryIndex, modelId);
            parts = Cart.FilterFromCart(parts);
            partsListBox.Items.AddRange(parts.Select(x => x.Pavadinimas).ToArray());
        }

        // Prideti detaliu kainas
        private void toCart_Click(object sender, EventArgs e) {
            if (partsListBox.CheckedIndices.Count == 0)
                return;

            List<Detale> selectedParts = new List<Detale>();
            partsListBox.CheckedIndices.Cast<int>().ToList().
                ForEach(x => selectedParts.Add(parts[x]));

            Cart.AddRange(selectedParts.Select(x => x.Id).ToList());
            UpdateCartList();

            parts = Cart.FilterFromCart(parts);
            partsListBox.Items.Clear();
            partsListBox.Items.AddRange(parts.Select(x => x.Pavadinimas).ToArray());
        }

        private void fromCart_Click(object sender, EventArgs e) {
            if (cartListBox.CheckedItems.Count == 0)
                return;

            List<Detale> selectedParts = new List<Detale>();
            cartListBox.CheckedIndices.Cast<int>().ToList().
                ForEach(x => selectedParts.Add(Cart.Get(x)));

            Cart.RemoveRange(selectedParts.Select(x => x.Id).ToList());
            int modelId = modelsDropdown.SelectedIndex;
            var allParts = DetaleController.GetAvailableParts(selectedCategoryIndex, modelId);
            parts = Cart.FilterFromCart(allParts);

            UpdateCartList();

            partsListBox.Items.Clear();
            partsListBox.Items.AddRange(parts.Select(x => x.Pavadinimas).ToArray());
        }

        public void UpdateCartList() {
            cartListBox.Items.Clear();
            cartListBox.Items.AddRange(Cart.GetAll().Select(x => x.Pavadinimas).ToArray());
        }

        private void makeOrder_Click(object sender, EventArgs e) {
            if (Cart.GetCount() == 0)
                return;

            new OrderForm(Cart.GetAll(), client, this).Show();
        }
    }
}
