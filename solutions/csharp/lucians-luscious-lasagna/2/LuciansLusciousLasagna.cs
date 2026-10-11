class Lasagna
{
    public int ExpectedMinutesInOven() => 40;

    public int RemainingMinutesInOven(int time) => ExpectedMinutesInOven() - time;

    public int PreparationTimeInMinutes(int layers) => 2 * layers;
    
    public int ElapsedTimeInMinutes(int layers, int minsElapsed)
    {
        return PreparationTimeInMinutes(layers) + minsElapsed;
    }
}
