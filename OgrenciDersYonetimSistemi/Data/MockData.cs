using System.Collections.Generic;
using OgrenciDersYonetimSistemi.Models;

namespace OgrenciDersYonetimSistemi.Data
{
    public static class MockData
    {
        public static List<OgretimGorevlisi> OgretimGorevlileri = new()
        {
            new OgretimGorevlisi { Id = 1, Name = "Dr. Ahmet", Bolum = "Bilgisayar Mühendisliği" },
            new OgretimGorevlisi { Id = 2, Name = "Doç. Dr. Mehmet", Bolum = "Elektrik-Elektronik Mühendisliği" },
            new OgretimGorevlisi { Id = 3, Name = "Prof. Dr. Ayşe", Bolum = "Matematik" }
        };

        public static List<Ders> Dersler = new()
        {
            new Ders { Id = 1, Ad = "Matematik", Kredi = 4 },
            new Ders { Id = 2, Ad = "Fizik", Kredi = 3 },
            new Ders { Id = 3, Ad = "Programlama", Kredi = 5 }
        };
    }
}
