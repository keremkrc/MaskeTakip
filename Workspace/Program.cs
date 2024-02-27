using Business.Concrete;
using Entities.Concrete;

namespace Workspace
{
    class Program
    {

        static void Main(string[] args)
        {

            // Degiskenler();
            Vatandas vatandas1 = new Vatandas();
            Person person1 = new Person();
            person1.FirstName = "Kerem";
            person1.LastName = "Karaca";
            person1.NationalIdentity = 123;
            person1.DateofBirthYear = 2003;



            PttManager pttManager = new PttManager(new PersonManager());

            pttManager.GiveMask(person1);

            Console.ReadLine();

        }

        static void SelamVer()
        {
            Console.WriteLine("Merhaba ");
        }

        static int Topla(int sayi1, int sayi2 = 3)
        {
            return sayi1 + sayi2;
        }

        private static void Degiskenler()
        {
            string mesaj = "Merhaba";
            double tutar = 100000;  //db'den gelen veri
            int sayi = 100;
            bool girisYapmisMi = false;

            string ad = "Kerem";
            string soyad = "Karaca";
            int dogumYili = 2003;
            long tcNo = 12345678910;


            Console.WriteLine(tutar * 1.18);

            Console.WriteLine(tutar * 1.18);
        }
    }

    //pascal case
    public class Vatandas
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }
    }

}



// SOLID

// S - Single Responsibility Principle (Tek Sorumluluk Prensibi)
// O - Open/Closed Principle (Açık/Kapalı Prensibi)
// L - Liskov Substitution Principle (Liskov'un Yerine Geçme Prensibi)
// I - Interface Segregation Principle (Arayüz Ayrımı Prensibi)
// D - Dependency Inversion Principle (Bağımlılıkların Ters Çevrilmesi Prensibi)

// S - Single Responsibility Principle (Tek Sorumluluk Prensibi)
// Bir sınıfın sadece bir sorumluluğu olmalıdır. Yani bir sınıfın sadece bir işi olmalıdır.
//
//
// O - Open/Closed Principle (Açık/Kapalı Prensibi)
// Yazılım varlıkları (class, modül, fonksiyon vb.) gelişime açık, değişime kapalı olmalıdır.
//
//
// L - Liskov Substitution Principle (Liskov'un Yerine Geçme Prensibi)
// Bir sınıf alt sınıfı ile yer değiştirdiğinde aynı davranışı sergilemelidir.
//
//
// I - Interface Segregation Principle (Arayüz Ayrımı Prensibi)
// Bir sınıfın ihtiyacı olmayan metotları içermemesi gerekmektedir.
//
//
// D - Dependency Inversion Principle (Bağımlılıkların Ters Çevrilmesi Prensibi)
// Yazılım varlıkları (class, modül, fonksiyon vb.) somut sınıflara değil, soyutlamalara bağımlı olmalıdır.

