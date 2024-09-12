Console.WriteLine(12+25);
//Console.WriteLine(12 + 25);
//Console.WriteLine(12 + 25);
//Console.WriteLine(12 + 25);
//Console.WriteLine(12 + 25);
//Console.WriteLine(12 + 25);
// Değişken oluşturma 
// veri_tipi değiken_ismi = değişken_değeri;

// string : metinsel ifadeler için kulllandığımız veri tipiir.

string metin = "Aklıma hiçbir şey gelmiyor.";

// Değişken ismi tanımlanırken sayısal ifade ile başlayamaz
Console.WriteLine(metin);

// int : tam sayılara karşılık gelen bir veri tipidir.
int sayi1 = 26;
int sayi2 = 42;
int toplam = sayi1 + sayi2;
int cikar = sayi1 - sayi2;
int carpma = sayi1 * sayi2;
int bolum = sayi1 / sayi2;

// 26 + 42 = 68
Console.WriteLine(sayi1+ " + "+sayi2 + "= "+toplam);

// String interpolation 
Console.WriteLine($"{sayi1} - {sayi2} = {cikar}");
Console.WriteLine(carpma);
Console.WriteLine(bolum);

string name = "Ömer ";
string soyad = "Doğan";

string tumAd = soyad + name;
Console.WriteLine(tumAd);

// double : ondalıklı sayılara karşılık gelen veri tipidir.

double number1 = 25;
double number2 = 35.89;
Console.WriteLine(number2/number1);

// float : ondalıklı sayılar için kullandığımız veri tipidir.
float number3 = 25;
float number4 = 35.89f;
Console.WriteLine(number4/number3);

// bool : Doğruluk ifadesi taşır. iki farklı değer alır true , false

bool dogru = true;
bool yanlis = false;
Console.WriteLine(dogru);
Console.WriteLine(yanlis);

// karşılaştırma operatörleri 
// < küçüktür 
// > büyüktür 
// >= büyük eşittir
// <= küçük eşitttir.
// == eşit midir ?
// != eşit değil midir? 

Console.WriteLine(3<11); // True
Console.WriteLine(3 > 11); // False
Console.WriteLine(3 >= 3); // True
Console.WriteLine(3 <= 1); // False
Console.WriteLine(3 != 11); // True
Console.WriteLine(0 == 0); // True

var deneme = 3 < 11;
Console.WriteLine(deneme.GetType());

// mantıksal operatörler.
// ||(pipe) veya
// &&(ampersan) ve



Console.WriteLine(3<11 || 3!=3);
//                  True   veya False = True
Console.WriteLine(3 < 11 && 3 != 3);
//                  True ve False = False


Console.WriteLine(5==5 || 300<96); // True

Console.WriteLine(5 == 5 && 300 < 96); // False

Console.WriteLine(6>=4 || 4<6); // True
Console.WriteLine(6 >= 4 && 4 < 6); // True


// Ternary operatör : ? 

// Kullanıcıdan bir yaş Değeri alarak ehliyet alma durumunu ekrana çıktı alarak veriniz.

//Console.WriteLine("Lütfen yaşınızı giriniz : ");
//int age = Convert.ToInt32(Console.ReadLine());

//string result = age >= 18 ? "Ehliyet alabilir" : "Ehliyet Alamaz";
//Console.WriteLine(result);

// karar mekanizmaları: (if else , switch case)
//if (age>=18)
//{
//    Console.WriteLine("Ehliyet alabilirsiniz.");
//}
//else
//{
//    Console.WriteLine("Ehliyet alamaz.");
//}

Console.WriteLine("Lütfen bir sayı giriniz: ");
int sayi = Convert.ToInt32(Console.ReadLine());

if (sayi < 0)
{
    Console.WriteLine("Girmiş olduğunuz sayı negatiftir.");
}
else if (sayi ==0)
{
    Console.WriteLine("Girmiş olduğunuz sayı 0 dır.");
}
else
{
    Console.WriteLine("Girmiş olduğunuz sayı pozitiftir.");
}

