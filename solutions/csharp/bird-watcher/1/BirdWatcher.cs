using System.Linq;
class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        //throw new NotImplementedException("Please implement the (static) BirdCount.LastWeek() method");
        //since this is a static method and we are provided with the info, we initialisa an array and return it
        int[] lastWeek = {0, 2, 5, 3, 7, 8, 4};
        Console.WriteLine(lastWeek);
        return lastWeek;
    }

    public int Today()
    {
        //throw new NotImplementedException("Please implement the BirdCount.Today() method");
        // return the last element in the array array[array.Count - 1]
        /* this is a method call
        birdCount.Today();
        birdCount → the object/instance (or variable)
        Today() → the method
        . → member-access operator
        () → indicates the method takes no arguments
        */
        //first get birdcount from the call
        
        Console.WriteLine(birdsPerDay[birdsPerDay.Count() - 1]);
        return birdsPerDay[birdsPerDay.Count() - 1];
    }

    public void IncrementTodaysCount()
    {
        //throw new NotImplementedException("Please implement the BirdCount.IncrementTodaysCount() method");
        // call today and increment
        //Console.WriteLine(birdsPerDay); // => System.Int32[] because no access
        int today = birdsPerDay[birdsPerDay.Count() - 1];
        today += 1;
        birdsPerDay[birdsPerDay.Count() - 1] = today;
    }

    public bool HasDayWithoutBirds()
    {
        //throw new NotImplementedException("Please implement the BirdCount.HasDayWithoutBirds() method");
        // lamda expression Find 0 for any element in array, if null return true else false
        return birdsPerDay.Any(bird => bird == 0); // remember to include using System.Linq
    }

    public int CountForFirstDays(int numberOfDays)
    {
        //throw new NotImplementedException("Please implement the BirdCount.CountForFirstDays() method");
        int total = 0;
        for (int i = 0; i < numberOfDays; i++) {
            total += birdsPerDay[i];
        }
        return total;
    }

    public int BusyDays()
    {
        //throw new NotImplementedException("Please implement the BirdCount.BusyDays() method");
        //remember to use System.Linq
        return birdsPerDay.Count(bird => bird >= 5);
        // return the number of elements found where element is greater than or equal to 5
        // Go through every element in birdsPerDay, and add to count if bird >= limit
    }
}
