using autodalys.Models;
using System.Collections.Generic;
using System.Data;

namespace autodalys.Controllers
{
    public class KebuloTipasController
    {
        public static List<KebuloTipas> GetBodyTypes() {
            List<KebuloTipas> list = new List<KebuloTipas>();
            var query = $"SELECT * FROM kėbulų_tipai";
            var dataTable = Sql.Query(query);

            foreach (DataRow row in dataTable) {
                list.Add(FromTableRow(row));
            }

            return list;
        }

        private static KebuloTipas FromTableRow(DataRow row) {
            int id = (int)row["id"];
            string name = row["name"].ToString();

            return new KebuloTipas {
                Id = id,
                Name = name,
            };
        }
    }
}
