class RemoteControlCar
{
    private readonly int _speed;
    private readonly int _batteryDrain;
    
    private int _batteryCharge = 100;
    private int _distanceDriven;
    
    public RemoteControlCar(int speed, int batteryDrain)
    {
        _speed = speed;
        _batteryDrain = batteryDrain;
    }
    
    public bool BatteryDrained() =>  _batteryCharge < _batteryDrain;

    public int DistanceDriven() => _distanceDriven;

    public void Drive()
    {
        if (!BatteryDrained())
        {
            _distanceDriven += _speed;
            _batteryCharge -= _batteryDrain;
        }
    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50, 4);
    }
}

class RaceTrack
{
    private readonly int _distance;

    public RaceTrack(int distance)
    {
        _distance = distance;
    }
    
    public bool TryFinishTrack(RemoteControlCar car)
    {
        while (car.DistanceDriven() < _distance)
        {
            if (car.BatteryDrained())
            {
                return false;
            }
            car.Drive();
        }
    return true;
    }
}
