using autodalys.Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace autodalys.Controllers
{
    public class KlientasController
    {
        public static List<Klientas> GetClients() {
            var clients = new List<Klientas>();
            var dataTable = Sql.Query("SELECT * FROM klientai");

            foreach (DataRow row in dataTable) {
                clients.Add(FromTableRow(row));
            }

            return clients;
        }

        public static Klientas Find(long asmensKodas) {
            var query = $"SELECT * FROM klientai WHERE asmens_kodas = {asmensKodas}";
            var dataTable = Sql.Query(query);

            if (dataTable.Count > 0) {
                return FromTableRow(dataTable[0]);
            }

            return null;
        }

        public static long CreateClient(Klientas client) {
            var query = $"INSERT INTO klientai VALUES ({client.AsmensKodas}, \"{client.Vardas}\", " +
                $"\"{client.Pavarde}\", \"{client.TelefonoNr}\", \"{client.ElPastas}\", {client.Amzius}, " +
                $"'{client.GimimoData.Date}')";
            Sql.Insert(query);
            Console.WriteLine($"Client {client.AsmensKodas} created");
            return client.AsmensKodas;
        }

        private static Klientas FromTableRow(DataRow row) {
            long asmensKodas = (long)row["asmens_kodas"];
            string vardas = row["vardas"].ToString();
            string pavarde = row["pavardė"].ToString();
            string telefonoNr = row["telefono_nr"].ToString();
            string elPastas = row["el_paštas"].ToString();
            int amzius = (int)row["amžius"];
            DateTime gimimoData = Convert.ToDateTime(row["gimimo_data"]);

            return new Klientas {
                AsmensKodas = asmensKodas,
                Vardas = vardas,
                Pavarde = pavarde,
                TelefonoNr = telefonoNr,
                ElPastas = elPastas,
                Amzius = amzius,
                GimimoData = gimimoData
            };
        }
    }
}
