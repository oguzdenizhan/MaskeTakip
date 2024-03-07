
using Business.Concrete;
using Entities.Concrete;



namespace WorkAround
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Degiskenler();
            //Vatandas vatandas1 = new();
            //SelamVer("Ahmet");
            //SelamVer("Ayşe");
            //SelamVer();

            //int sonuc = Topla(5,1);
            //sonuc = Topla();
            //sonuc = Topla(50);


            //Diziler
            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Ali";
            ogrenciler[1] = "Veli";
            ogrenciler[2] = "Mahmut";
            ogrenciler = new string[4];
            ogrenciler[3] = "Berkay";

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new string[] { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);

            int sayi1 = 10;
            int sayi2 = 20;
            sayi2 = sayi1;
            sayi1 = 30;
            Console.WriteLine(sayi1);
            foreach (string sehir in sehirler2)
            {
                Console.WriteLine(sehir);
            }

            List<string> yeniSehirler= new List<string> {"Ankara1","İstanbul1","İzmir1"};
            yeniSehirler.Add("Bursa1");
            foreach(string sehir in yeniSehirler)
            {Console.WriteLine(sehir);

            }

            Person person1 = new Person();
            person1.FirstName = "Engin";
            person1.LastName = "Demiroğ";
            person1.DateOfBirthYear = 1985;
            person1.NationalIdentity = 123;

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);
            Console.ReadLine();
        }

        static void SelamVer(string isim = "")
        {
            Console.WriteLine("Merhaba " + isim);
        }
        static int Topla(int sayi1 = 2, int sayi2 = 8)
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


