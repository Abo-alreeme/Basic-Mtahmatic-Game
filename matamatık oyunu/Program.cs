using System;

class MatematikBulmacaOyunu
{
    static void Main()
    {
        Console.WriteLine("Matematik Bulmaca Oyununa Hoş Geldiniz!");
        Console.WriteLine("Seviyeyi seçin: 1- Başlangıç | 2- Orta | 3- İleri");
        int seviye = int.Parse(Console.ReadLine());

        int puan = 0;

        for (int i = 0; i < 5; i++) // 5 soru
        {
            string soru = SoruUret(seviye, out int dogruCevap);
            Console.WriteLine($"Soru {i + 1}: {soru}");

            int kullaniciCevap = int.Parse(Console.ReadLine());
            if (kullaniciCevap == dogruCevap)
            {
                Console.WriteLine("Doğru cevap! +10 puan");
                puan += 10;
            }
            else
            {
                Console.WriteLine($"Yanlış cevap. Doğru cevap: {dogruCevap}");
            }
        }

        Console.WriteLine($"Oyun bitti! Toplam puanınız: {puan}");
    }

    static string SoruUret(int seviye, out int cevap)
    {
        Random rastgele = new Random();
        int sayi1 = rastgele.Next(1, 20);
        int sayi2 = rastgele.Next(1, 30);

        switch (seviye)
        {
            case 1: // Başlangıç
                cevap = sayi1 + sayi2;
                return $"{sayi1} + {sayi2}";
            case 2: // Orta
                cevap = sayi1 * sayi2;
                return $"{sayi1} * {sayi2}";
            case 3: // İleri
                cevap = (int)Math.Pow(sayi1, 2);
                return $"{sayi1} sayısının karesi nedir?";
            default:
                cevap = 0;
                return "Bilinmeyen seviye";
        }
    }
}
