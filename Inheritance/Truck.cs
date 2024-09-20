namespace Inheritance;

public sealed class Truck : MotorVehicle
{
   
    public bool Dorse { get; set; }

    public override string ToString()
    {
        return $"Id: {Id}, Teker Sayısı : {NumberOfWheels}" +
            $"Rengi : {ColorName}, Yakıt Tipi : {FuelType}" +
            $"Kapı Sayısı : {NumberOfDoor}, Motor Hacmi : {MotorVolume}" +
            $"Dorse si Varmı :{Dorse}";
    }
}
