using autodalys.Controllers;
using autodalys.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace autodalys
{
    public partial class ReportLD3ResultsForm : Form
    {
        private List<ReportLD3> reports;

        public ReportLD3ResultsForm(List<ReportLD3> reports) {
            InitializeComponent();
            this.reports = reports;

            dataGridView1.Columns.Add("vin", "VIN");
            dataGridView1.Columns.Add("mileage", "Rida");
            dataGridView1.Columns.Add("model", "Modelis");
            dataGridView1.Columns.Add("carDate", "Automobilio metai");
            dataGridView1.Columns.Add("date", "Sutarties data");
            dataGridView1.Columns.Add("price", "Sutarties kaina");
            dataGridView1.Columns.Add("employeeCode", "Darbuotojo kodas");
            dataGridView1.Columns.Add("carCount", "Tų metų auto skaičius");
            dataGridView1.Columns.Add("contractCount", "Tų metų sutarčių skaičius");
            dataGridView1.Columns.Add("mileageAvg", "Markės ridos vidurkis");
            dataGridView1.Columns.Add("priceAvg", "Metų vid. sutarčių kaina");
            dataGridView1.Columns.Add("employeeWorkTime", "Darbuotojo dirbamas laikas");
            FillDataGridView();
        }

        private void FillDataGridView() {
            dataGridView1.Rows.Clear();

            foreach (ReportLD3 row in reports) {
                int years = row.DarbuotojoDirbamasLaikasD / 365;
                int months = (row.DarbuotojoDirbamasLaikasD % 365) / 30;
                int days = (row.DarbuotojoDirbamasLaikasD % 365) % 30;
                string employeeDate = $"{years} m., {months} mėn. ir {days} d.";
                dataGridView1.Rows.Add(row.Vin, row.Rida, ModelisController.GetModelFromId(row.ModelioId).Pavadinimas,
                row.AutomobilioMetai.ToShortDateString(), row.SutartiesSudarymoData.ToShortDateString(),
                row.SutartiesKaina, row.DarbuotojoVidKodas, row.MetuAutoSkaicius, row.MetuSutarciuSkaicius,
                row.MarkesRidosVidurkis.ToString("F2"), row.MetuVidSutarciuKaina.ToString("F2"), employeeDate);
            }
        }

        private void backButton_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
