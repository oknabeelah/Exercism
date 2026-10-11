class Lasagna
{
    public int ExpectedMinutesInOven()
    {
        return 40;
    }

    public int RemainingMinutesInOven(int time)
    {
        int remainder = (ExpectedMinutesInOven() - time);
        return remainder;
    }

    public int PreparationTimeInMinutes(int layers)
    {
        int prepTime = (2 * layers);
        return prepTime;
    }
    
    public int ElapsedTimeInMinutes(int layers, int minsElapsed)
    {
        int elapsedTime = (PreparationTimeInMinutes(layers) + minsElapsed);
        return elapsedTime;
    }
}
