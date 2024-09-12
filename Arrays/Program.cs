//string[] sehirler = { "Malatya", "Adana","İstanbul","ADIYAMAN", "İzmir","Hakkari","Aydın","Elazığ","Bingöl"};
////                       0          1        2            3        4        5        6 
//Console.WriteLine(sehirler[2]);

//Console.WriteLine("For döngüsü ile");
//for (int i = 0; i<sehirler.Length; i++)
//{
//    Console.WriteLine(sehirler[i]);
//}
//Console.WriteLine("Foreach döngüsü ile");
//foreach (string sehir in sehirler) 
//{
//    Console.WriteLine(sehir);
//}

//Console.WriteLine($"şehirler dizisi kaç elemanlıdır : {sehirler.Length}");

int[] sayilar = { 20, 1, 2, 5, 6, 4, 22, 3, 0, -1, -25, -8, 6, 9 };
//Array.Sort(sayilar);
//foreach (int say in sayilar)
//{
//    Console.WriteLine(say);
//}

// sayilar dizisinde 4 ten büyük olan bütün sayıları ekrana yazdıran kod


Console.WriteLine("1. Yöntem");
foreach (int x in sayilar)
{
    if (x>4)
    {
        Console.WriteLine(x);
    }
}
Console.WriteLine("2. Yöntem: Lambda Expression");

int[] filteredNumbers = Array.FindAll(sayilar,x=> x>4 );
Array.ForEach(filteredNumbers, x=> Console.WriteLine(x));

Console.WriteLine("3. Yöntem: ");
Array.ForEach(sayilar, x=>
{
    if (x>4)
    {
        Console.WriteLine(x);
    }
});
// Ülkeler dizisi oluşturunuz {"Almanya","Uganda","Zimbabwe","Germanya","İngiltere"}
// bu ülkeler dizisi içerisinde A veya a harfi geçenleri listeleyen kodu yazınız.

string[] ulkeler = { "Almanya", "Uganda", "Zimbabwe", "Germanya", "İngiltere" };
Array.ForEach(ulkeler, x =>
{
    // 1. Yöntem : x.ToLower().Contains('a')
    // 2. Yöntem : x.Contains("A") || x.Contains('a')
    // 3. Yöntem : 
    if (x.Contains("a",StringComparison.InvariantCultureIgnoreCase))
    {
        Console.WriteLine(x);
    }
});


// {10,36,45,12,54,88,55,1,3,7,9}
// 1. Görev : bütün elemanları toplayan kodu yazınız
// 2. Görev : bu dizinin aritmetik ortalamasını hesaplayınız.
// 3. Görev : bu dizide en büyük elemanı bulan kodu yazınız.
// 4. Görev : bu dizide en küçük elemanı bulan kodu yazınız.

int[] arrays = { 10, 36, 45, 12, 54, 88, 55, 1, 3, 7, 9 };
Console.WriteLine($"arrayin elemanlarının toplamı : {arrays.Sum()}");
Console.WriteLine($"arrayin aritmetik ortalaması : {arrays.Average()}");
Console.WriteLine($"arrayin en büyük elemanı: {arrays.Max()}");
Console.WriteLine($"arrayin en küçük elemanı: {arrays.Min()}");

