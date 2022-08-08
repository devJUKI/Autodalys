using System;

namespace autodalys.Models
{
    public class Klientas
    {
        public long AsmensKodas { get; set; }
        public string Vardas { get; set; }
        public string Pavarde { get; set; }
        public string TelefonoNr { get; set; }
        public string ElPastas { get; set; }
        public int Amzius { get; set; }
        public DateTime GimimoData { get; set; }
    }
}
