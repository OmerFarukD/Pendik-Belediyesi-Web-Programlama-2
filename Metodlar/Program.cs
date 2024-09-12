Result(3,45);

// Değer döndürmeyen parametresiz metodlar 
// Ekran çıktısı olarak benim adım büşra 

void Info()
{
    Console.WriteLine("Benim adım Büşra");
}

void Info2(string name)
{
    Console.WriteLine($"Benim adım  {name}");
}

void Info3(string name, string surname, int age)
{
    Console.WriteLine($"adım : {name}, soyadım :{surname}, yaşım: {age}");
}

// MeyveYazdir(string meyveAdi, double fiyat , double kg);

void MeyveYazdir(string meyveAdi, double fiyat, double kg)
{
    Console.WriteLine($"meyve adı : {meyveAdi}, fiyat: {fiyat}, kg: {kg}");
}

int Topla(int sayi1, int sayi2)
{
    return sayi1+sayi2;
}

// 2 tane sayının çarpımını ekran çıktısı olarak veren kodu yazınnız.


// çarpımı bul
// ekrana yazdır

void Result(int sayi1, int sayi2)
{
    int carpim = Carpim(sayi1,sayi2);
    EkranaYazdir(sayi1,sayi2,carpim);
   
}

void EkranaYazdir(int sayi1, int sayi2, int crpm)
{
    Console.WriteLine($"{sayi1} * {sayi2} = {crpm}");
}

int Carpim(int num1, int num2)
{
    return num1 * num2;
}

