using System;

namespace autodalys.Models
{
    public class Sutartis
    {
        public int Id { get; set; }
        public DateTime SudarymoData { get; set; }
        public decimal Kaina { get; set; }
        public long KlientoAsmensKodas { get; set; }
        public string DarbuotojoVidinisKodas { get; set; }
    }
}
