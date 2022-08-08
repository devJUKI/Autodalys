using autodalys.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autodalys.Controllers
{
    public class BukleController
    {
        public static List<Bukle> GetCarStates() {
            List<Bukle> list = new List<Bukle>();
            var query = $"SELECT * FROM automobilio_būklės";
            var dataTable = Sql.Query(query);

            foreach (DataRow row in dataTable) {
                list.Add(FromTableRow(row));
            }

            return list;
        }

        private static Bukle FromTableRow(DataRow row) {
            int id = (int)row["id"];
            string name = row["name"].ToString();

            return new Bukle {
                Id = id,
                Name = name,
            };
        }
    }
}
