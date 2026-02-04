class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
       int[] lastWeek = {0, 2, 5, 3 , 7, 8, 4 };
        return lastWeek;
    }

    public int Today()
    {
        int birdsToday = birdsPerDay[6];
        return birdsToday;
    }

    public void IncrementTodaysCount()
    {
        int birdsToday = birdsPerDay[6];
        birdsPerDay[6] = birdsToday + 1;
    }

    public bool HasDayWithoutBirds()
    {
        foreach (int bird in birdsPerDay)
        {
            if(bird == 0)
            {
                return true;
            }    
        }
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int birdCount = 0;
        for(int i = 0; i < numberOfDays; i++){
            birdCount += birdsPerDay[i];
        }

        return birdCount;
    }

    public int BusyDays()
    {
        int birdCount = 0;
        foreach(int bird in birdsPerDay){
            if(bird == 5){
                birdCount += bird;
            }
        }

        return birdCount;
    }
}
