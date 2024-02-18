// See https://aka.ms/new-console-template for more information

    void Degiskenler()
    {
        //Console.WriteLine("Hello, World!");
        


        string mesaj = "Merhaba";
        double tutar = 100000; // db den gelr
        int sayi = 100;
        bool girisYapmisMi = false;

        string ad = "Engin";
        string soyad = "Demiroğ";
        int dogumYili = 1985;
        long tcNo = 12345678910;
    }

    SelamVer("Engin");
    SelamVer("Ahmet");
    SelamVer("Ayşe");
    SelamVer();

    Degiskenler();

    

    Vatandas vatandas1 = new Vatandas();   // 1adet instance olusturduk.
    //classların defult u internal
    //degiskenlerin default private
    //pascal casing

    Console.ReadLine();
    int sonuc = Topla(3,5);

    static void SelamVer(string isim ="isimsiz")
    {
        Console.WriteLine("merhaba" + isim);
    }

    static int Topla(int sayi1 , int sayi2)
    {
        int sonuc = sayi1 + sayi2;
        Console.WriteLine("Toplam:  " + sonuc.ToString());
        return sonuc;
    }

    //diziler / Arrays

    string ogrenci1 = "Engin";
    string ogrenci2 = "Kerem";
    string ogrenci3 = "Berkay";

    string[] ogrenciler = new string[3];  //3 elemanlı dizi oldu.

    for (int i = 0; i < ogrenciler.Length; i++)
    {
        Console.WriteLine(ogrenciler[i]);
    }

    string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" }; 
    string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

    sehirler2 = sehirler1;
    sehirler1[0] = "Adana";
Console.WriteLine(sehirler2[0]);




    foreach (string sehir in sehirler1)   //dizileri foreachlede gezebiliyoruz.
    {
        Console.WriteLine(sehir);    //sehir her bir elemanı gezerken ona verdiğimiz takma isim.
    }

    List<string> yenisehirler1 = new List<string> { "Ankara", "İstanbul", "İzmir" };
yenisehirler1.Add("Adana 1");
    foreach (var sehir in yenisehirler1)
    {
        Console.WriteLine(sehir);
    }
    Console.ReadLine();



  


public class Vatandas
{
    //public string ad = "Engin";
    //public string soyad = "Demiroğ";
    //public int dogumYili = 1985;
    //public long tcNo = 12345678910;

    public string Ad { get; set; }
    public string Soyad { get; set; }
    public int DogumYili { get; set; }
    public long TcNo { get; set; }


}

