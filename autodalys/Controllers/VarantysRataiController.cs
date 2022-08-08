using autodalys.Models;
using System.Collections.Generic;
using System.Data;

namespace autodalys.Controllers
{
    public class VarantysRataiController
    {
        public static List<VarantysRatai> GetPoweredWheels() {
            List<VarantysRatai> list = new List<VarantysRatai>();
            var query = $"SELECT * FROM varantys_ratai";
            var dataTable = Sql.Query(query);

            foreach (DataRow row in dataTable) {
                list.Add(FromTableRow(row));
            }

            return list;
        }

        private static VarantysRatai FromTableRow(DataRow row) {
            int id = (int)row["id"];
            string name = row["name"].ToString();

            return new VarantysRatai {
                Id = id,
                Name = name,
            };
        }
    }
}
