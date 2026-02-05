class RemoteControlCar
{
    private int _batteryPercentage = 100;
    private int _driveDistance = 20;
    private int _metersDriven = 0;
    
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return $"Driven {_metersDriven} meters";
    }

    public string BatteryDisplay()
    {
        if(_batteryPercentage > 0){
            return $"Battery at {_batteryPercentage}%";
        }
        return "Battery empty";
        
    }

    public void Drive()
    {
        if(_batteryPercentage > 0){
           _metersDriven += 20;
            _batteryPercentage -= 1;
        }
        
    }
}
