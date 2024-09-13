
using Encapsulation;

User user = new User()
{
    Name = "Deniz",
    Surname = "Kaya",
    Email = "denizkaya@gmail.com",
    Password = "123456",
};
// User -> Name , Surname, Email, Password, FullName
Console.WriteLine(user);


// Kayısı -> Kayısının Cinsi , kayısının ağırlığı , kayısının fiyatı
// kayısının çekirdek fiyatı , Stok durumu, Menşei , ToplamUcret(Sadece okunur)

// Toplam ucret alanı : (((kayısının ağırlığı+kayısının çekirdek fiyatı)*2/3)*stok durumu )

// Tüm alanlar değiştirilemez olsun


// public KayisiCinsi {get; init;};

Apricot apricot = new Apricot()
{
    Cins = "Hasanbey",
    CekirdekFiyat = 50,
    Fiyat = 200,
    Kg = 3500,
    Stok = 250,
    Mensei = "mALATYA"
};
Console.WriteLine(apricot);