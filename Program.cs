using System;

namespace Metot_OverLoading
{
    class Program
    {
        static void Main(string[] args)
        {
            //out parametreler
            string sayi = "999";

            bool sonuc = int.TryParse(sayi, out int outSayi);
            if (sonuc)
            {
                Console.WriteLine("Başarılı");
                Console.WriteLine(outSayi);
            }
            else
            {
                Console.WriteLine("Başarısız");

            }

            Metotlar instance = new Metotlar();
            instance.Topla(4, 5, out int toplamSonucu);
            Console.WriteLine(toplamSonucu);
            //out return'ün yaptığı işi yapar. 

            //Metot Aşırı Yükleme- Overloading
            //Fonksiyonun imzasını değiştirip onu birden fazla şekilde kullanabilme

            int ifade = 999;
            instance.EkranaYazdir(ifade.ToString());
            instance.EkranaYazdir(ifade);
            instance.EkranaYazdir("Furkan","Korkmaz");

            //Metot İmzası
            //Metot Adı+parametre sayısı+parametre tipi
        }

        public class Metotlar
        {
            public void Topla(int a, int b, out int toplam)
            {
                toplam = a+b;
            }
            public void EkranaYazdir(string veri)
            {
                Console.WriteLine(veri);
            }
            public void EkranaYazdir(int veri)
            {
                Console.WriteLine(veri);
            }
             
           public void EkranaYazdir(string veri1, string veri2)
            {
                Console.WriteLine(veri1+ veri2);
            }
        }
    }
}
