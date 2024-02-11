//Değişkenler();

using Business.Concrete;
using Entities.Concrete;
using System;

static void SelamVer(string isim = "isimsiz")
{
    Console.WriteLine("merhaba" + isim);
}

SelamVer("ali");
SelamVer("ayşe");
SelamVer("cemil");
SelamVer();

static int Topla(int sayi1, int sayi2)
{
    int sonuc = sayi1 + sayi2;
    Console.WriteLine("Toplam:" + sonuc);
    return sonuc;
}

Topla(3, 5);



string[] myList = new string[] { "Antalya", "izmir" };
myList = myList.Concat(new string[] { "Bu eklenen şehir" }).ToArray();


//static void AddCity(string city)
//{

//}



foreach (string s in myList)
{
    Console.WriteLine(s);
}

List<string> list = new List<string> { "hatay" };
list.Add("çankaya");

foreach (string s in list)
{
    Console.WriteLine(s);
}

Person person1 = new Person();
person1.DatOfBirthYear = 1994;
person1.FirstName = "Tugay";
person1.NationalId = 123;
person1.LastName = "Deniz";

PttManager pttManager = new PttManager(new ForeignerManager());
pttManager.GiveMask(person1);

static void Değişkenler()
{
    string? mesaj = "merhaba";
    double? tutar = 10000; //db den gelir
    int? sayi = 100;
    bool? girisYapmisMi = false;

    string? name = "Ad";
    string? surName = "Soyad";
    int? birthOfDate = 1994;
    long? tcNo = 12345678910;
    Console.WriteLine("Hello, World!");

    Console.ReadLine();
}

public class Vatandas
{
    public int? Id { get; set; }
    public string? Ad { get; set; }
    public string? SoyAd { get; set; }
    public int? DogumYili { get; set; }
    public long? TcNo { get; set; }
}

