// Kullanıcıdan 3 tane sınav notu alınız 
// 1. Sınav , 2. Sınav , 3. Sınav , Not ortalamanız , 

// 1. Yöntem
// NotYazdir(sinav1, sinav2, sinav3);

// 2. Yöntem
// NotYazdir(sinav1, sinav2, sinav3) ->
// double ortalama= OrtalamaHesapla(sinav1, sinav2, sinav3);
// EkranaYazdir(sinav1, sinav2, sinav3,ortalama)


//Console.WriteLine("Lütfen 1. notunuzu giriniz");
//int sayi1 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Lütfen 2. notunuzu giriniz");
//int sayi2 = Convert.ToInt32(Console.ReadLine());


//Console.WriteLine("Lütfen 3. notunuzu giriniz");
//int sayi3 = Convert.ToInt32(Console.ReadLine());

//NotYazdir(sayi1,sayi2,sayi3);
int bolum;
int kalan;

Bolme(10,3, out bolum, out kalan);

Console.WriteLine("10  / 3 = "+bolum);
Console.WriteLine("10 % 3 = " + kalan);


void NotYazdir(int sayi1, int sayi2, int sayi3)
{
    double ortalama = OrtalamaHesapla(sayi1,sayi2,sayi3);
    EkranaYazdir(sayi1, sayi2, sayi3,ortalama);

}

void EkranaYazdir(int sayi1, int sayi2, int sayi3, double ortalama)
{
    Console.WriteLine($"1. Sınavınız : {sayi1}");
    Console.WriteLine($"2. Sınavınız : {sayi2}");
    Console.WriteLine($"3. Sınavınız : {sayi3}");
    Console.WriteLine($"Ortalamanız : {ortalama}");
}

double OrtalamaHesapla(int sayi1, int sayi2, int sayi3)
{
    return (sayi1 + sayi2 + sayi3) / 3;
}

int Faktoriyel(int n)
{
    int total = 1;
    for (int i = 1; i<=n;i++)
    {
        total = total * i;
    }

    return total;
}

int Permutasyon(int n, int r)
{
    return Faktoriyel(n) / Faktoriyel(n-r);
}

int Kombinasyon(int n, int r)
{
    return Permutasyon(n, r) / Faktoriyel(r);
}

int Topla(params int[] sayilar)
{
    int total = 0;
    foreach (int sayi in sayilar)
    {
        total = total + sayi;
    }
    return total;
}

void Bolme(int bolunen, int bolen, out int bolum, out int kalan)
{
    bolum = bolunen / bolen;
    kalan = bolunen % bolen;
}

// "MeRhAbAlAr" -> merhabalar , MERHABALAR