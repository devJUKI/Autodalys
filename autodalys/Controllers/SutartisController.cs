using autodalys.Models;
using System;
using System.Data;

namespace autodalys.Controllers
{
    public class SutartisController
    {
        public static long CreateContract(Sutartis contract) {
            var query = $"INSERT INTO sutartys (sudarymo_data, kaina, kliento_asmens_kodas, darbuotojo_vidinis_kodas) VALUES " +
                $"('{DateTime.Now.Date}', {contract.Kaina.ToString().Replace(',', '.')}, {contract.KlientoAsmensKodas}, \"{contract.DarbuotojoVidinisKodas}\")";
            
            long id = Sql.Insert(query);
            return id;
        }

        private static Sutartis FromTableRow(DataRow row) {
            int id = (int)row["id"];
            DateTime sudarymoData = Convert.ToDateTime(row["sudarymo_data"]);
            decimal kaina = (decimal)row["kaina"];
            long klientoAsmensKodas = (long)row["kliento_asmens_kodas"];
            string darbuotojoVidinisKodas = row["darbuotojo_vidinis_kodas"].ToString();

            return new Sutartis {
                Id = id,
                SudarymoData = sudarymoData,
                Kaina = kaina,
                KlientoAsmensKodas = klientoAsmensKodas,
                DarbuotojoVidinisKodas = darbuotojoVidinisKodas
            };
        }
    }
}
