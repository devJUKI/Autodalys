using autodalys.Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace autodalys.Controllers {
    public class ModelisController {
        public static List<Modelis> GetModels() {
            var makes = new List<Modelis>();
            var dataTable = Sql.Query("SELECT * FROM modeliai");

            foreach (DataRow row in dataTable) {
                makes.Add(FromTableRow(row));
            }

            return makes;
        }

        public static List<Modelis> GetModels(int makeId) {
            var makes = new List<Modelis>();
            var dataTable = Sql.Query($"SELECT * FROM modeliai WHERE markės_id = {makeId}");

            foreach (DataRow row in dataTable) {
                makes.Add(FromTableRow(row));
            }

            return makes;
        }

        public static Modelis GetModel(string name) {
            var dataTable = Sql.Query($"SELECT * FROM modeliai WHERE pavadinimas = \"{name}\"");
            return (dataTable.Count > 0) ? FromTableRow(dataTable[0]) : null;
        }

        public static long CreateModel(string name, int make) {
            var sql = $"INSERT INTO modeliai (pavadinimas, markės_id) VALUES (\"{name}\", {make})";
            long id = Sql.Insert(sql);
            return id;
        }

        public static int GetModelId(string modelName) {
            var dataTable = Sql.Query($"SELECT id FROM modeliai WHERE pavadinimas = \"{modelName}\"");
            return (dataTable.Count > 0) ? (int)dataTable[0]["id"] : -1;
        }

        public static Modelis GetModelFromId(int id) {
            var dataTable = Sql.Query($"SELECT * FROM modeliai WHERE id = {id}");
            return FromTableRow(dataTable[0]);
        }

        public static List<Modelis> GetModels(string make) {
            var makes = new List<Modelis>();
            var dataTable = Sql.Query($"SELECT * FROM modeliai WHERE modeliai.markės_id = " +
                $"(SELECT markės.id FROM markės WHERE markės.pavadinimas = \"{make}\")");

            foreach (DataRow row in dataTable) {
                makes.Add(FromTableRow(row));
            }

            return makes;
        }

        private static Modelis FromTableRow(DataRow row) {
            string pavadinimas = row["pavadinimas"].ToString();
            int id = (int)row["id"];
            int markesId = (int)row["markės_id"];

            return new Modelis {
                Pavadinimas = pavadinimas,
                Id = id,
                MarkesId = markesId
            };
        }
    }
}
