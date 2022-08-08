using autodalys.Models;
using System.Collections.Generic;
using System.Data;

namespace autodalys.Controllers {
    public class KategorijaController {
        public static List<Kategorija> GetCategories() {
            var makes = new List<Kategorija>();
            var dataTable = Sql.Query("SELECT * FROM detalių_kategorijos");

            foreach (DataRow row in dataTable) {
                makes.Add(FromTableRow(row));
            }

            return makes;
        }

        public static Kategorija GetCategory(string name) {
            var dataTable = Sql.Query($"SELECT * FROM detalių_kategorijos WHERE " +
                $"pavadinimas = \"{name}\"");
            return (dataTable.Count > 0) ? FromTableRow(dataTable[0]) : null;
        }

        public static int CreateCategory(string name) {
            // INSERT INTO detalių_kategorijos (pavadinimas) VALUES ("kategorijaTest")
            var sql = $"INSERT INTO detalių_kategorijos (pavadinimas) VALUES (\"{name}\")";
            long id = Sql.Insert(sql);
            return (int)id;
        }

        private static Kategorija FromTableRow(DataRow row) {
            string pavadinimas = row["pavadinimas"].ToString();
            int id = (int)row["id"];

            return new Kategorija {
                Pavadinimas = pavadinimas,
                Id = id,
            };
        }
    }
}
