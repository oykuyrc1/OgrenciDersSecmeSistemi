using System;
using System.Collections.Generic;
using System.Linq;
using OgrenciDersYonetimSistemi.Models;
using OgrenciDersYonetimSistemi.Data;

namespace OgrenciDersYonetimSistemi
{
    class Program
    {
        static void Main(string[] args)
        {
            string ogrenciFilePath = "ogrenciler.xml";
            List<Ogrenci> ogrenciler = File.Exists(ogrenciFilePath)
                ? XmlHelper.DeserializeFromXml<List<Ogrenci>>(ogrenciFilePath)
                : new List<Ogrenci>();

            Console.WriteLine("=== Öğretim Görevlileri ===");
            foreach (var ogretimGorevlisi in MockData.OgretimGorevlileri)
            {
                ogretimGorevlisi.BilgiGoster();
            }

            Console.Write("Bir öğretim görevlisi seçin (ID): ");
            int ogretimGorevlisiId = int.Parse(Console.ReadLine());
            var secilenOgretimGorevlisi = MockData.OgretimGorevlileri.FirstOrDefault(o => o.Id == ogretimGorevlisiId);

            Console.WriteLine("=== Dersler ===");
            foreach (var ders in MockData.Dersler)
            {
                Console.WriteLine($"ID: {ders.Id}, Adı: {ders.Ad}, Kredi: {ders.Kredi}");
            }

            Console.Write("Bir ders seçin (ID): ");
            int dersId = int.Parse(Console.ReadLine());
            var secilenDers = MockData.Dersler.FirstOrDefault(d => d.Id == dersId);

            secilenDers.OgretimGorevlisi = secilenOgretimGorevlisi;

            Console.Write("Öğrenci adı girin: ");
            string ogrenciAdi = Console.ReadLine();
            Ogrenci yeniOgrenci = new() { Id = ogrenciler.Count + 1, Name = ogrenciAdi };
            ogrenciler.Add(yeniOgrenci);
            secilenDers.KayitliOgrenciler.Add(yeniOgrenci);

            XmlHelper.SerializeToXml(ogrenciler, ogrenciFilePath);

            Console.WriteLine("\n=== Ders Bilgileri ===");
            Console.WriteLine($"Ders Adı: {secilenDers.Ad}, Kredi: {secilenDers.Kredi}, Öğretim Görevlisi: {secilenDers.OgretimGorevlisi.Name}");
            Console.WriteLine("Kayıtlı Öğrenciler:");
            foreach (var ogrenci in secilenDers.KayitliOgrenciler)
            {
                Console.WriteLine($"- {ogrenci.Name}");
            }
        }
    }
}

