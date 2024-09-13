

Console.WriteLine("Hello, World!");
// Computer ->  Marka,Ram , Islemci , Ekran Kartı, stok, Fiyat



Computer computer =new Computer();
computer.EkranKarti = "Nvidia gtx 1050ti";
computer.Marka = "Msi Bravo";
computer.Ram = 32;
computer.Islemci = "İntel i7 13000h";
computer.Stock = 25;
computer.Fiyat = 18000;

Computer bilgisayar = new Computer("Monster Abra",32,"İntel i5 13000H","NVIDIA RTX 4070",25,58000);



Console.WriteLine(bilgisayar);
ComputerManager bilgisayarYontecisi = new ComputerManager();


Console.WriteLine(computer);
Computer bilgisayar1 = new Computer()
{
    EkranKarti = "Deneme xyz",
    Fiyat = 25,
    Islemci = "Deneme işlemcisi",
    Marka = string.Empty,
    Ram = 32,
    Stock = 36
};

bilgisayarYontecisi.Add(bilgisayar1);





class Computer
{

    public Computer()
    {

    }

    public Computer(string marka, int ram, string islemci, string ekranKarti,int stock, double fiyat)
    {
        Marka = marka;
        Ram = ram;
        Islemci = islemci;
        EkranKarti = ekranKarti;
        Stock = stock;
        Fiyat = fiyat;
    }

    public string Marka;
    public int Ram;
    public string Islemci;
    public string EkranKarti;
    public int Stock;
    public double Fiyat;


    public void EkranaYaz()
    {
        Console.WriteLine($"Bilgisayarın markası : {Marka}");
        Console.WriteLine($"Bilgisayarın Ram i :{Ram} Gb");
        Console.WriteLine($"Bilgisayarın İşlemcisi :{Islemci}");
        Console.WriteLine($"Bilgisayarın Stok adedi :{Stock} ");
        Console.WriteLine($"Bilgisayarın Fiyatı :{Fiyat} ");
    }

    //public override string ToString()
    //{
    //    return $"Marka : {Marka}, Ram: {Ram}, İşlemci: {Islemci}," +
    //        $"Stok : {Stock}, Fiyat: {Fiyat}";
    //}
    public override string ToString()
    {
        return $"Marka : {Marka}, Ram: {Ram}, İşlemci: {Islemci}," +
            $"Stok : {Stock}, Fiyat: {Fiyat}";
    }
}

// bilgisayar ekle 
// bilgisayar güncelle
// bilgisayar sil 
class ComputerManager
{
    public void Add(Computer computer)
    {
        if (computer.Ram<0)
        {
            Console.WriteLine("Bilgisayarın Ram i 0 dan küçük olamaz.");
            return;
        }

        if (string.IsNullOrWhiteSpace(computer.Marka))
        {
            Console.WriteLine("Bilgisayarın marka değeri alanı zorunludur.");
            return;
        }
        Console.WriteLine("Bilgisayar eklendi");
        computer.EkranaYaz();
        // veri tabanına bağlan 
        // veriyi ekle 
        // hata yoksa olayları kaydet
        Console.WriteLine("************************************");
    }

    public void Remove(Computer computer) {
        Console.WriteLine("Bilgisayar silindi");
        computer.EkranaYaz();
        // veri tabanına bağlan 
        // veriyi sil 
        // hata yoksa olayları kaydet
        Console.WriteLine("************************************");
    }

    public void Update(Computer computer)
    {
        Console.WriteLine("Bilgisayar güncellendi.");
        computer.EkranaYaz();
        Console.WriteLine("************************************");
    }
}