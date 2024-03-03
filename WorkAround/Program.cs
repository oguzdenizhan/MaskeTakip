using System.Net.NetworkInformation;

namespace WorkAround
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Degiskenler();
            Vatandas vatandas1 = new();
            SelamVer("Ahmet");
            SelamVer("Ayşe");
            SelamVer();

            int sonuc = Topla(5,1);
            sonuc = Topla();
            sonuc = Topla(50);



            Console.ReadLine();
        }

        static void SelamVer(string isim="")
        {
            Console.WriteLine("Merhaba "+isim);
        }
        static int Topla(int sayi1=2,int sayi2 = 8)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam " + sonuc);
            return sonuc;
        }
        private static void Degiskenler()
        {
            double tutar = 10000;
            bool girisYapmisMi = false;
            string ad = "Oguzhan";
            string soyad = "Denizhan";
            int dogumYili = 1975;
            long tcNo = 12345678910;
        }

    }
    public class Vatandas
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }


    }
}


