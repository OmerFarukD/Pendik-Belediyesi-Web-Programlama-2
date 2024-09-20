

namespace Inheritance;

public sealed class Car :  MotorVehicle
{


    public override string ToString()
    {
        return $"Id: {Id}, Teker Sayısı : {NumberOfWheels}" +
            $"Rengi : {ColorName}, Yakıt Tipi : {FuelType}" +
            $"Kapı Sayısı : {NumberOfDoor}, Motor Hacmi : {MotorVolume}";
    }

}
