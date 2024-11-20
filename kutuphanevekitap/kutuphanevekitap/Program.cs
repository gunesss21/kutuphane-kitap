using System;
using System.Collections.Generic;

// Kitap sınıfı: Kitapları temsil eder
public class Kitap
{
    public string Baslik { get; set; }        // Kitabın başlığı
    public string Yazar { get; set; }         // Kitabın yazarı

    // Kitap yapıcısı
    public Kitap(string baslik, string yazar)
    {
        Baslik = baslik;
        Yazar = yazar;
    }

    // Kitap bilgilerini yazdırma metodu
    public override string ToString()
    {
        return $"{Baslik} - {Yazar}";
    }
}

// Kütüphane sınıfı: Kitapları yönetir
public class Kutuphane
{
    private List<Kitap> kitaplar;

    // Kütüphane yapıcısı
    public Kutuphane()
    {
        kitaplar = new List<Kitap>();
    }

    // Kitap ekleme metodu
    public void KitapEkle(Kitap kitap)
    {
        kitaplar.Add(kitap);
        Console.WriteLine($"{kitap.Baslik} kütüphaneye eklendi.");
    }

    // Kitap kaldırma metodu
    public void KitapKaldir(string baslik)
    {
        var kitap = kitaplar.Find(k => k.Baslik == baslik);
        if (kitap != null)
        {
            kitaplar.Remove(kitap);
            Console.WriteLine($"{kitap.Baslik} kütüphaneden kaldırıldı.");
        }
        else
        {
            Console.WriteLine("Kitap bulunamadı.");
        }
    }

    // Tüm kitapları listeleme metodu
    public void TumKitaplariListele()
    {
        if (kitaplar.Count == 0)
        {
            Console.WriteLine("Kütüphanede kitap bulunmamaktadır.");
        }
        else
        {
            Console.WriteLine("Kütüphanedeki Kitaplar:");
            foreach (var kitap in kitaplar)
            {
                Console.WriteLine(kitap);
            }
        }
    }
}

// Program sınıfı: Uygulamanın ana giriş noktası
public class Program
{
    public static void Main(string[] args)
    {
        // Kitaplar oluşturuluyor
        Kitap kitap1 = new Kitap("C# Programlama", "Ahmet Yılmaz");
        Kitap kitap2 = new Kitap("Veri Yapıları", "Mehmet Demir");
        Kitap kitap3 = new Kitap("Algoritmalar", "Ayşe Kara");

        // Kütüphane oluşturuluyor
        Kutuphane kutuphane = new Kutuphane();

        // Kitaplar kütüphaneye ekleniyor
        kutuphane.KitapEkle(kitap1);
        kutuphane.KitapEkle(kitap2);
        kutuphane.KitapEkle(kitap3);

        // Kütüphanedeki tüm kitaplar listeleniyor
        kutuphane.TumKitaplariListele();

        // Bir kitap kütüphaneden kaldırılıyor
        kutuphane.KitapKaldir("Veri Yapıları");

        // Güncel kitap listesi tekrar gösteriliyor
        kutuphane.TumKitaplariListele();
    }
}
