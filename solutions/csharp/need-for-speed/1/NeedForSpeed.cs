class RemoteControlCar
{
    private int _speed {get; set;}
    private int _batteryDrain {get; set;}
    private int _batteryCharge {get; set;}
    private int _distanceDriven {get; set;}
    
    public RemoteControlCar(int speed, int batteryDrain, int batteryCharge = 100, int distanceDriven = 0)
    {
        this._speed = speed;
        this._batteryDrain = batteryDrain;
        this._batteryCharge = batteryCharge;
        this._distanceDriven = distanceDriven;
    }
    
    public bool BatteryDrained() =>  _batteryCharge <= 0 || _batteryCharge < _batteryDrain;

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
        int _batteryDrain  = 4;
        int _speed = 50;
        
        RemoteControlCar Nitro = new RemoteControlCar(_speed, _batteryDrain);
        return Nitro;
    }
}

class RaceTrack
{
    public int _distance;

    public RaceTrack(int distance)
    {
        this._distance = distance;
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
