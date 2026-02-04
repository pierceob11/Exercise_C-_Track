class Lasagna
{
    public int _timeNeededInOven = 40;
    public int _prepTimePerLayer = 2;
    
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven(){
        return _timeNeededInOven;
    }

    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int timeAlreadyInOven){
        int remainingTime = _timeNeededInOven - timeAlreadyInOven;
        return remainingTime;
    }

    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int numberOfLayers){
        int prepTime = numberOfLayers * _prepTimePerLayer;

        return prepTime;
        
    }

    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int numberOfLayers, int numberOfMinutesInOven){
        // Sum of prep time + time in oven
        int prepTime = PreparationTimeInMinutes(numberOfLayers);

        int elapsedTime = prepTime + numberOfMinutesInOven;
            return elapsedTime;
    }
}
