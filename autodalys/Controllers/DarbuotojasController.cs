using autodalys.Models;
using System;
using System.Data;

namespace autodalys.Controllers
{
    public class DarbuotojasController
    {
        public static Darbuotojas Find(string code) {
            var query = $"SELECT * FROM darbuotojai WHERE vidinis_kodas = \"{code}\"";
            var dataTable = Sql.Query(query);

            if (dataTable.Count > 0) {
                return FromTableRow(dataTable[0]);
            }

            return null;
        }

        private static Darbuotojas FromTableRow(DataRow row) {
            string vidinisKodas = row["vidinis_kodas"].ToString();
            string vardas = row["vardas"].ToString();
            string pavarde = row["pavardė"].ToString();
            string telefonoNr = row["telefono_nr"].ToString();
            string elPastas = row["el_paštas"].ToString();
            DateTime ydarbinimoData = Convert.ToDateTime(row["įdarbinimo_data"]);
            DateTime gimimoData = Convert.ToDateTime(row["gimimo_data"]);
            int amzius = (int)row["amžius"];
            decimal atlyginimas = (decimal)row["atlyginimas"];

            return new Darbuotojas {
                VidinisKodas = vidinisKodas,
                Vardas = vardas,
                Pavarde = pavarde,
                TelefonoNr = telefonoNr,
                ElPastas = elPastas,
                YdarbinimoData = ydarbinimoData,
                GimimoData = gimimoData,
                Amzius = amzius,
                Atlyginimas=atlyginimas
            };
        }
    }
}
