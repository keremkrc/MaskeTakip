namespace Workspace
{
    class Program
    {

        static void Main(string[] args)
        {
            // Degiskenler();
            Vatandas vatandas1 = new Vatandas();

            SelamVer();
            SelamVer();
            SelamVer();
            Topla(2);
            Console.WriteLine(Topla(1));

            Console.ReadLine();

        }

        static void SelamVer()
        {
            Console.WriteLine("Merhaba ");
        }

        static int Topla(int sayi1, int sayi2=3)
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
