
namespace Encapsulation;

public class Apricot
{


    public string Cins { get; init; }
    public int Kg { get; init; }

    public double Fiyat { get; init; }

    public double CekirdekFiyat { get; init; }

    public int Stok { get; set; }

    public string Mensei { get; init; }

    public double ToplamUcret => ((Kg + CekirdekFiyat) * 2 / 3) * Stok;

    public override string ToString()
    {
        return $"Cins: {Cins}, Kg: {Kg}, Fiyat: {Fiyat}" +
            $"Cekirdek Fiyatı: {CekirdekFiyat}, Stok: {Stok}" +
            $"Menşei : {Mensei}, Toplam Ucret : {ToplamUcret}";
    }
}
