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
    public partial class ReportLD3Form : Form
    {
        public ReportLD3Form() {
            InitializeComponent();
        }

        private void getReportButton_Click(object sender, EventArgs e) {
            List<ReportLD3> reports = ReportLD3Controller.GetReports((int)ridaMin.Value, 
                (int)ridaMax.Value, dataMin.Value, dataMax.Value);
            new ReportLD3ResultsForm(reports).ShowDialog();
        }

        private void backButton_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
