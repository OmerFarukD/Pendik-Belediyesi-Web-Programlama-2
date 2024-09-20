namespace Inheritance;

public class Bicycle : Vehicle
{
    public string CarpetType { get; set; }

    public override string ToString()
    {
        return $"Id: {Id}, Teker Sayısı : {NumberOfWheels}" +
            $"Rengi : {ColorName}, Sepet Türü : {CarpetType}";
    }
}
