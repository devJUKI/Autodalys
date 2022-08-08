using autodalys.Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace autodalys.Controllers
{
    internal static class ReportLD3Controller
    {
        public static List<ReportLD3> GetReports(int ridaMin, int ridaMax, DateTime dateMin, DateTime dateMax) {
            var query = "SELECT automobiliai.vin, automobiliai.rida, automobiliai.modelio_id, automobiliai.pagaminimo_data, sutartys.sudarymo_data AS \"sutarties_sudarymo_data\", sutartys.kaina AS \"sutarties_kaina\", sutartys.darbuotojo_vidinis_kodas, " +
                      "(SELECT COUNT(*) FROM automobiliai AS auto WHERE YEAR(auto.pagaminimo_data) = YEAR(automobiliai.pagaminimo_data)) AS \"tų_metų_auto_skaičius\", " +
                      "(SELECT COUNT(*) FROM sutartys AS sutar WHERE YEAR(sutar.sudarymo_data) = YEAR(sutartys.sudarymo_data)) AS \"sutartys_tais_metais\", " +
                      "(SELECT AVG(auto.rida) FROM automobiliai AS auto WHERE auto.modelio_id IN(SELECT modeliai.id FROM modeliai WHERE modeliai.markės_id = (SELECT markės.id FROM markės WHERE markės.id = (SELECT modeliai1.markės_id FROM modeliai AS modeliai1 WHERE modeliai1.id = automobiliai.modelio_id)))) AS \"markės_ridos_vidurkis\", " +
                      "(SELECT AVG(sutar.kaina) FROM sutartys AS sutar WHERE YEAR(sutar.sudarymo_data) = YEAR(sutartys.sudarymo_data)) AS \"vid_metų_sutarčių_kaina\", " +
                      "(SELECT DATEDIFF(DATE(NOW()), darbuotojai.įdarbinimo_data) FROM darbuotojai WHERE darbuotojai.vidinis_kodas = sutartys.darbuotojo_vidinis_kodas) AS \"darbuotojo_dirbamas_laikas\"" +
                      "FROM automobiliai LEFT JOIN sutartys ON automobiliai.sutarties_id = sutartys.id " +
                      $"WHERE(automobiliai.rida BETWEEN {ridaMin} AND {ridaMax})" +
                      $"AND(sutartys.sudarymo_data BETWEEN '{dateMin.ToShortDateString()}' AND '{dateMax.ToShortDateString()}') " +
                      $"ORDER BY automobiliai.rida";
            var dataTable = Sql.Query(query);

            List<ReportLD3> result = new List<ReportLD3>();
            foreach (DataRow row in dataTable) {
                result.Add(FromTableRow(row));
            }

            return result;
        }

        private static ReportLD3 FromTableRow(DataRow row) {
            string vin = row["vin"].ToString();
            int rida = int.Parse(row["rida"].ToString());
            int modelioId = int.Parse(row["modelio_id"].ToString());
            DateTime automobilioMetai = Convert.ToDateTime(row["pagaminimo_data"]);
            DateTime sutartiesSudarymoData = Convert.ToDateTime(row["sutarties_sudarymo_data"]);
            decimal sutartiesKaina = decimal.Parse(row["sutarties_kaina"].ToString());
            string darbuotojoVidKodas = row["darbuotojo_vidinis_kodas"].ToString();
            int metuAutoSkaicius = int.Parse(row["tų_metų_auto_skaičius"].ToString());
            int metuSutarciuSkaicius = int.Parse(row["sutartys_tais_metais"].ToString());
            double markesRidosVidurkis = double.Parse(row["markės_ridos_vidurkis"].ToString());
            decimal metuVidSutarciuKaina = decimal.Parse(row["vid_metų_sutarčių_kaina"].ToString());
            int darbuotojoDirbamasLaikasD = int.Parse(row["darbuotojo_dirbamas_laikas"].ToString());

            return new ReportLD3 {
                Vin = vin,
                Rida = rida,
                ModelioId = modelioId,
                AutomobilioMetai = automobilioMetai,
                SutartiesSudarymoData = sutartiesSudarymoData,
                SutartiesKaina = sutartiesKaina,
                DarbuotojoVidKodas = darbuotojoVidKodas,
                MetuAutoSkaicius = metuAutoSkaicius,
                MetuSutarciuSkaicius = metuSutarciuSkaicius,
                MarkesRidosVidurkis = markesRidosVidurkis,
                MetuVidSutarciuKaina = metuVidSutarciuKaina,
                DarbuotojoDirbamasLaikasD = darbuotojoDirbamasLaikasD
            };
        }
    }
}
