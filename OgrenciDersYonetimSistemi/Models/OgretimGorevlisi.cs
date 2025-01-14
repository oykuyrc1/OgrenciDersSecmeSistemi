namespace OgrenciDersYonetimSistemi.Models
{
    public class OgretimGorevlisi : BaseEntity
    {
        public string Bolum { get; set; }

        public override void BilgiGoster()
        {
            Console.WriteLine($"ID: {Id}, Adı: {Name}, Bölüm: {Bolum}");
        }
    }
}
