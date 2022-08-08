
using autodalys.Models;
using System.Collections.Generic;
using System.Data;

namespace autodalys.Controllers
{
    public class PavaruDezeController
    {
        public static List<PavaruDeze> GetTransmissionTypes() {
            List<PavaruDeze> list = new List<PavaruDeze>();
            var query = $"SELECT * FROM pavarų_dėžės";
            var dataTable = Sql.Query(query);

            foreach (DataRow row in dataTable) {
                list.Add(FromTableRow(row));
            }

            return list;
        }

        private static PavaruDeze FromTableRow(DataRow row) {
            int id = (int)row["id"];
            string name = row["name"].ToString();

            return new PavaruDeze {
                Id = id,
                Name = name,
            };
        }
    }
}
