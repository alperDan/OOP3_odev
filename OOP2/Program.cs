using OOP2;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Alper";
            musteri1.Soyadi = "Dan";
            musteri1.TcNo = "12345";
           

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "12345";
            musteri2.SirketAdi = "GanyanBayii";
            musteri2.VergiNo = "12345";
            

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);


        }
    }
}
