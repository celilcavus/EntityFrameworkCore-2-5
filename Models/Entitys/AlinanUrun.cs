namespace Models.Entitys
{
    public class AlinanUrun
    {
        public int Id { get; set; }
        public int FirmaId { get; set; }
        public Firma? Firma { get; set; }

        public int UrunId { get; set; }
        public Urun? Urun { get; set; }
        public DateTime Tarih { get; set; }
        public int Miktar { get; set; }
    }
}