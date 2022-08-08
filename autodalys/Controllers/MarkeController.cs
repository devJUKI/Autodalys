using autodalys.Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace autodalys.Controllers {
    public class MarkeController {
        public static List<Marke> GetMakes() {
            var makes = new List<Marke>();
            var dataTable = Sql.Query("SELECT * FROM markės");

            foreach (DataRow row in dataTable) {
                makes.Add(FromTableRow(row));
            }

            return makes;
        }

        public static int GetMakeId(string name) {
            var dataTable = Sql.Query($"SELECT id FROM markės WHERE pavadinimas = \"{name}\"");
            return (dataTable.Count > 0) ? (int)dataTable[0]["id"] : -1;
        }

        public static Marke GetMake(string name) {
            var dataTable = Sql.Query($"SELECT * FROM markės WHERE pavadinimas = \"{name}\"");
            return (dataTable.Count > 0) ? FromTableRow(dataTable[0]) : null;
        }

        public static long CreateMake(string name) {
            var sql = $"INSERT INTO markės (pavadinimas) VALUES (\"{name}\")";
            long id = Sql.Insert(sql);
            return id;
        }

        private static Marke FromTableRow(DataRow row) {
            string pavadinimas = row["pavadinimas"].ToString();
            int id = (int)row["id"];

            return new Marke {
                Pavadinimas = pavadinimas,
                Id = id
            };
        }
    }
}
