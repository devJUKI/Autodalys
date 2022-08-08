using System;

namespace autodalys.Models
{
    public class Darbuotojas
    {
        public string VidinisKodas { get; set; }
        public string Vardas { get; set; }
        public string Pavarde { get; set; }
        public string TelefonoNr { get; set; }
        public string ElPastas { get; set; }
        public DateTime YdarbinimoData { get; set; }
        public DateTime GimimoData { get; set; }
        public int Amzius { get; set; }
        public decimal Atlyginimas { get; set; }
    }
}
