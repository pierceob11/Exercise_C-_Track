class RemoteControlCar
{
    int _speed = 5;
    int _batteryAmount = 100;
    int _batteryDrain = 2;
    int _distanceDriven = 0;
    
    // TODO: define the constructor for the 'RemoteControlCar' class
    public RemoteControlCar(int speed, int batteryDrain){
        _speed = speed;
        _batteryDrain = batteryDrain;
    }

    public bool BatteryDrained()
    {
        if(_batteryAmount < _batteryDrain){
            return true;
        }
        else{
            return false;
        }
    }

    public int DistanceDriven()
    {
        return _distanceDriven;
    }

    public void Drive()
    {
        if(!BatteryDrained()){
            _distanceDriven += _speed;
        _batteryAmount -= _batteryDrain;
        }
        
        
    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50, 4);
    }
}

class RaceTrack
{
    int _distance = 800;
    
    // TODO: define the constructor for the 'RaceTrack' class
    public RaceTrack(int distance){
        _distance = distance;
        
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        while(!car.BatteryDrained()){
            car.Drive();
            
            if(car.DistanceDriven() >= _distance){
                return true;
            }
            else if(car.BatteryDrained()){
                return false;
            }
        }
        return false;
    }
}
