using autodalys.Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace autodalys.Controllers {
    public class DetaleController {
        public static List<Detale> GetParts() {
            var parts = new List<Detale>();
            var dataTable = Sql.Query("SELECT * FROM detalės");

            foreach (DataRow row in dataTable) {
                parts.Add(FromTableRow(row));
            }
            
            return parts;
        }

        public static List<Detale> GetPartsByIds(List<int> ids) {
            if (ids.Count == 0)
                return new List<Detale>();

            var parts = new List<Detale>();
            string sqlOperatorParams = string.Empty;
            ids.ForEach(id => sqlOperatorParams += id + ", ");
            sqlOperatorParams = sqlOperatorParams.Remove(sqlOperatorParams.Length - 2, 2);
            var dataTable = Sql.Query($"SELECT * FROM detalės WHERE id IN ({sqlOperatorParams})");

            foreach (DataRow row in dataTable) {
                parts.Add(FromTableRow(row));
            }

            return parts;
        }

        public static Detale GetPartById(int id) {
            var parts = new List<Detale>();
            var dataTable = Sql.Query($"SELECT * FROM detalės WHERE " +
                $"id = {id}");

            return FromTableRow(dataTable[0]);
        }

        public static List<Detale> GetAvailableParts(int categorieId, int modelId) {
            var parts = new List<Detale>();

            var dataTable = Sql.Query($"SELECT * FROM `detalės` " +
                $"WHERE automobilio_vin IN " +
                $"(SELECT automobiliai.vin FROM automobiliai WHERE automobiliai.modelio_id = {modelId}) " +
                $"AND užsakymo_id IS NULL AND kategorijos_id = {categorieId}");
            
            foreach (DataRow row in dataTable) {
                parts.Add(FromTableRow(row));
            }

            return parts;
        }

        public static int CreatePart(Detale part) {
            //INSERT INTO detalės(pavadinimas, kaina, užsakymo_id, kategorijos_id, automobilio_vin) VALUES("TestDetale", 1959, NULL, 6, "3LN6L2LU3DR773073")
            var sql = $"INSERT INTO detalės (pavadinimas, kaina, užsakymo_id, kategorijos_id, automobilio_vin) VALUES " +
                $"(\"{part.Pavadinimas}\", {part.Kaina.ToString().Replace(',', '.')}, NULL, {part.KategorijosId}, \"{part.AutomobilioVin}\")";
            long id = Sql.Insert(sql);
            return (int)id;
        }

        private static Detale FromTableRow(DataRow row) {
            int id = (int)row["id"];
            string pavadinimas = row["pavadinimas"].ToString();
            decimal kaina = (decimal)row["kaina"];
            object uzsakymoId = row["užsakymo_id"];
            int kategorijosId = (int)row["kategorijos_id"];
            string automobilioVin = row["automobilio_vin"].ToString();

            return new Detale {
                Id = id,
                Pavadinimas = pavadinimas,
                Kaina = kaina,
                UzsakymoId = uzsakymoId,
                KategorijosId = kategorijosId,
                AutomobilioVin = automobilioVin
            };
        }
    }
}
