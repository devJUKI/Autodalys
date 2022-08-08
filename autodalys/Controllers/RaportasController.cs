using autodalys.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autodalys.Controllers
{
    public class RaportasController
    {
        public static List<Raportas> GetReports() {
            List<Raportas> list = new List<Raportas>();
            var query = $"SELECT * FROM pirkimų_raportai";
            var dataTable = Sql.Query(query);

            foreach (DataRow row in dataTable) {
                list.Add(FromTableRow(row));
            }

            return list;
        }

        public static void UpdateRaport(Raportas raport) {
            var sql = $"UPDATE pirkimų_raportai SET pirkimų_skaičius = {raport.PirkimuSkaicius}, " +
                $"išleista_suma = {raport.IsleistaSuma}, mėnuo = {raport.Menuo}, " +
                $"darbuotojo_vidinis_kodas = \"{raport.DarbuotojoVidinisKodas}\" " +
                $"WHERE id = {raport.Id}";
            Sql.Update(sql);
        }

        public static void DeleteRaport(int id) {
            var sql = $"DELETE FROM pirkimų_raportai WHERE id = {id}";
            Sql.Delete(sql);
        }

        private static Raportas FromTableRow(DataRow row) {
            int id = (int)row["id"];
            int pirkimuSkaicius = (int)row["pirkimų_skaičius"];
            decimal isleistaSuma = decimal.Parse(row["išleista_suma"].ToString().Replace('.', ','));
            int menuo = (int)row["mėnuo"];
            string darbuotojoVidinisKodas = row["darbuotojo_vidinis_kodas"].ToString();

            return new Raportas {
                Id = id,
                PirkimuSkaicius = pirkimuSkaicius,
                IsleistaSuma = isleistaSuma,
                Menuo = menuo,
                DarbuotojoVidinisKodas = darbuotojoVidinisKodas
            };
        }

    }
}
