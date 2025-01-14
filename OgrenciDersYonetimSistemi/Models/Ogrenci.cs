namespace OgrenciDersYonetimSistemi.Models
{
    public class Ogrenci : BaseEntity
    {
        public override void BilgiGoster()
        {
            Console.WriteLine($"Öğrenci ID: {Id}, Adı: {Name}");
        }
    }
}
