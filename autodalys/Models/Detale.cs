namespace autodalys.Models {
    public class Detale {
        public int Id { get; set; }
        public string Pavadinimas { get; set; }
        public decimal Kaina { get; set; }
        public object UzsakymoId { get; set; }
        public int KategorijosId { get; set; }
        public string AutomobilioVin { get; set; }
    }
}
