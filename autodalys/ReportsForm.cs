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
    public partial class ReportsForm : Form
    {
        public ReportsForm() {
            InitializeComponent();

            dataGridView1.Columns.Add("id", "Id");
            dataGridView1.Columns.Add("buyCount", "Pirkimų skaičius");
            dataGridView1.Columns.Add("moneySpent", "Išleista suma");
            dataGridView1.Columns.Add("month", "Mėnuo");
            dataGridView1.Columns.Add("employeeCode", "Darbuotojo vidinis kodas");
            FillDataGridView();
        }

        private void FillDataGridView() {
            dataGridView1.Rows.Clear();

            foreach (Raportas row in RaportasController.GetReports()) {
                dataGridView1.Rows.Add(row.Id, row.PirkimuSkaicius, row.IsleistaSuma, row.Menuo, row.DarbuotojoVidinisKodas);
            }
        }

        private void OnGridSelectionChanged(object sender, EventArgs e) {
            Console.WriteLine(dataGridView1.CurrentCell.RowIndex);
        }

        private void deleteEntry_Click(object sender, EventArgs e) {
            int id = RaportasController.GetReports()[dataGridView1.CurrentCell.RowIndex].Id;
            RaportasController.DeleteRaport(id);
            FillDataGridView();
        }

        private void changeEntry_Click(object sender, EventArgs e) {
            int id = RaportasController.GetReports()[dataGridView1.CurrentCell.RowIndex].Id;
            Raportas report = new Raportas {
                Id = id,
                PirkimuSkaicius = int.Parse(purchaseCount.Text),
                IsleistaSuma = decimal.Parse(purchaseCount.Text.Replace(',', '.')),
                Menuo = (int)month.Value,
                DarbuotojoVidinisKodas = employeeCode.Text
            };
            RaportasController.UpdateRaport(report);
            FillDataGridView();
        }

        private void BackButton_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
