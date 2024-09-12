for (int i = 0; i<=20; i+=2)
{
    Console.WriteLine(i);
}

Console.WriteLine("Tek sayıları listeleyen kod");
for (int i = 1; i<=20; i+=2)
{
    Console.WriteLine(i);
}
Console.WriteLine("Tek bir döngü ile tek çift ayrımı");
for(int i = 0; i<=20; i++)
{
    if (i % 2 ==0)
    {
        Console.WriteLine($"Çift sayı : {i}");
    }
    else
    {
        Console.WriteLine($"Tek sayı : {i}");
    }
}

// kullanıcıdan 1 sayı isteyiniz : 5
// 15

//Console.WriteLine("Lütfen bir sayı giriniz: ");
//int sayi = Convert.ToInt32(Console.ReadLine());

//int toplam = 0;

//for (int i =0; i<=sayi; i++)
//{
//    toplam = toplam + i;
//}
//Console.WriteLine(toplam);

// Kullanıcıdan bir sayı alınız ve bu sayının faktöriyelini hesaplayınız.
//Console.WriteLine("Lütfen bir sayı giriniz: ");
//int sayi = Convert.ToInt32(Console.ReadLine());
//int sonuc = 1;
//for (int i = 1;i<=sayi;i++)
//{
//    sonuc = sonuc * i;
//}
//Console.WriteLine(sonuc);

int telefonFiyat = 5000;
int bilgisayarFiyat = 10000;
int klavye = 1500;

Console.WriteLine("Kaç adet bilgisayar almak istiyorsunuz");
int bilgisayarAdet = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Kaç adet telefon almak istiyorsunuz");
int telefonAdet = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Kaç adet klavye almak istiyorsunuz");
int klavyeAdet = Convert.ToInt32(Console.ReadLine());

int toplamTelTutar = telefonAdet * telefonFiyat;
int toplamKlavyeTutar = klavye * klavyeAdet;
int toplamBilgisayarTutar = bilgisayarAdet * bilgisayarFiyat;

int total = toplamTelTutar + toplamKlavyeTutar + toplamBilgisayarTutar;

if (total<20000)
{
    Console.WriteLine($"Toplam ücret : {total}");
}
else if(total>=20000 && total<30000)
{
    double indirimli = total - (total * 0.2);
    Console.WriteLine($"İndirimsiz ücret : {total}");
    Console.WriteLine($"İndirimli ücret : {indirimli}");
    Console.WriteLine($"Aradaki fark : {total - indirimli}");
    Console.WriteLine($"İndirim oranı: %20");

}

else if (total >= 30000 && total < 35000)
{
    double indirimli = total - (total * 0.3);
    Console.WriteLine($"İndirimsiz ücret : {total}");
    Console.WriteLine($"İndirimli ücret : {indirimli}");
    Console.WriteLine($"Aradaki fark : {total - indirimli}");
    Console.WriteLine($"İndirim oranı: %30");
}
else
{
    Console.WriteLine("Bakiye yetersiz!!!!");
}




