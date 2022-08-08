using autodalys.Models;
using autodalys.Utilities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace autodalys
{
    public partial class OrderForm : Form {
        private List<Detale> parts;
        private Klientas client;
        private ClientForm clientForm;

        public OrderForm(List<Detale> parts, Klientas client, ClientForm clientForm) {
            InitializeComponent();
            this.parts = parts;
            this.client = client;
            this.clientForm = clientForm;

            decimal price = parts.Sum(x => x.Kaina);
            totalPrice.Text = $"Kaina viso: {price}";
        }

        private void confirmOrder_Click(object sender, EventArgs e) {
            if (!IsOrderDataValid())
                return;

            decimal price = parts.Sum(x => x.Kaina);
            var sql = $@"INSERT INTO užsakymai
                (
                    užsakymo_data,
                    miestas,
                    gatvė,
                    namo_numeris,
                    pašto_kodas,
                    kaina,
                    būsena,
                    kliento_asmens_kodas
                )
                VALUES
                (
                    '{DateTime.Now:yyyy-MM-dd}',
                    ""{townTB.Text}"",
                    ""{streetTB.Text}"",
                    {houseNrTB.Text},
                    ""{zipCodeTB.Text}"",
                    {price.ToString(CultureInfo.InvariantCulture)},
                    1,
                    {client.AsmensKodas}
                )".Replace("\r\n", "").Replace("    ", "");
            long id = Sql.Insert(sql);
            Console.WriteLine("New order created. ID: "+ id);

            string idsAppended = string.Empty;
            parts.ForEach(x => idsAppended += x.Id + ", ");
            idsAppended = idsAppended.Remove(idsAppended.Length - 2, 2);
            var updateSql = $"UPDATE detalės SET užsakymo_id = {id} WHERE id IN ({idsAppended})";
            int updatedRows = Sql.Update(updateSql);
            Console.WriteLine($"Ordered {updatedRows} parts");

            Cart.RemoveAll();
            clientForm.UpdateCartList();

            Close();
        }

        private bool IsOrderDataValid() {
            return townTB.Text != "" && streetTB.Text != "" && houseNrTB.Text != "" &&
                zipCodeTB.Text != "";
        }

        private void backButton_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
