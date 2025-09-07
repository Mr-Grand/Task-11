namespace Task_11;

public class PlatoonFactory
{
    public static int platoonCount = 0;
    private readonly int _maximumSoldiers = 10;
    public Platoon CreateSoldiers()
    {
        platoonCount++;
        Platoon platoon = new Platoon();
        platoon.name = "Platoon " + Convert.ToInt32(platoonCount);
        
        int soldiersCount = _maximumSoldiers;
        int soldier1Count = 4;
        soldiersCount -= soldier1Count;
        for (int i = 1; i <= soldier1Count; i++)
            platoon.AddSoldier(new Soldier1());
        
        int soldier2Count = RandomClass.Random.Next(0, soldiersCount+1);
        soldiersCount -= soldier2Count;
        for (int i = 1; i <= soldier2Count; i++)
            platoon.AddSoldier(new Soldier2());
        
        int soldier3Count = RandomClass.Random.Next(0, soldiersCount+1);
        soldiersCount -= soldier3Count;
        for (int i = 1; i <= soldier3Count; i++)
            platoon.AddSoldier(new Soldier3());
        
        int soldier4Count = soldiersCount;
        for (int i = 1; i <= soldier4Count; i++)
            platoon.AddSoldier(new Soldier4());


        return platoon;
    }
}