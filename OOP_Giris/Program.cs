Console.WriteLine("Hello, World!");
// Computer ->  Marka,Ram , Islemci , Ekran Kartı, stok, Fiyat

Computer computer =new Computer();
computer.EkranKarti = "Nvidia gtx 1050ti";
computer.Marka = "Msi Bravo";
computer.Ram = 32;
computer.Islemci = "İntel i7 13000h";
computer.Stock = 25;
computer.Fiyat = 18000;

//ComputerManager bilgisayarYontecisi = new ComputerManager();
//bilgisayarYontecisi.Add(computer);
//bilgisayarYontecisi.Remove(computer);
//bilgisayarYontecisi.Update(computer);

Console.WriteLine(computer);





class Computer
{
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
        // veri tabanına bağlan 
        // veriyi güncelle 
        // hata yoksa olayları kaydet
        Console.WriteLine("************************************");
    }
}
// TelefonManager class ını yazınız

