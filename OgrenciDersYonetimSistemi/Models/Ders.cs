using System.Collections.Generic;

namespace OgrenciDersYonetimSistemi.Models
{
    public class Ders
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public int Kredi { get; set; }
        public OgretimGorevlisi OgretimGorevlisi { get; set; }
        public List<Ogrenci> KayitliOgrenciler { get; set; } = new();
    }
}

