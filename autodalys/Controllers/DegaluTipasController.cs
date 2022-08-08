using autodalys.Models;
using System.Collections.Generic;
using System.Data;

namespace autodalys.Controllers
{
    public class DegaluTipasController
    {
        public static List<DegaluTipas> GetFuelTypes() {
            List<DegaluTipas> list = new List<DegaluTipas>();
            var query = $"SELECT * FROM degalų_tipai";
            var dataTable = Sql.Query(query);

            foreach (DataRow row in dataTable) {
                list.Add(FromTableRow(row));
            }

            return list;
        }

        private static DegaluTipas FromTableRow(DataRow row) {
            int id = (int)row["id"];
            string name = row["name"].ToString();

            return new DegaluTipas {
                Id = id,
                Name = name,
            };
        }
    }
}
