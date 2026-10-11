using System;

class RemoteControlCar
{
    // private fields in _camelCase. public methods in PascalCase.
    private int _totalDistanceTravelled;
    
    private int _remainingBatteryCharge = 100;
    
    public static RemoteControlCar Buy()
    {
        Console.WriteLine("Congratulation you have a new car!");
        return new RemoteControlCar();
    }

    public string DistanceDisplay() => $"Driven {_totalDistanceTravelled} meters";

    public string BatteryDisplay()
    {
        return _remainingBatteryCharge == 0 // ternary conditional operator
        ? "Battery empty"
        : $"Battery at {_remainingBatteryCharge}%";
    }

    public void Drive()
    {
        if (_remainingBatteryCharge > 0)
        {
            _totalDistanceTravelled += 20;
            _remainingBatteryCharge -= 1;
        }
    }

}
