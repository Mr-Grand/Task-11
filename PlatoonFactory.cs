namespace Task_11;

public class PlatoonFactory
{
    public static int PlatoonCount = 0;
    private readonly int _maximumSoldiers = 10;
    
    public Platoon CreateSoldiers()
    {
        PlatoonCount++;
        Platoon platoon = new Platoon();
        platoon.Name = "Platoon " + Convert.ToInt32(PlatoonCount);

        int soldiersCount = _maximumSoldiers;
        int soldier1Count = 4;
        soldiersCount -= soldier1Count;
        for (int i = 1; i <= soldier1Count; i++)
            platoon.AddSoldier(new SoldierCommon());

        int soldier2Count = RandomClass.Random.Next(0, soldiersCount + 1);
        soldiersCount -= soldier2Count;
        for (int i = 1; i <= soldier2Count; i++)
            platoon.AddSoldier(new SoldierCrit());

        int soldier3Count = RandomClass.Random.Next(0, soldiersCount + 1);
        soldiersCount -= soldier3Count;
        for (int i = 1; i <= soldier3Count; i++)
            platoon.AddSoldier(new SoldierMultipleHitDifferentTargets());

        int soldier4Count = soldiersCount;
        for (int i = 1; i <= soldier4Count; i++)
            platoon.AddSoldier(new SoldierMultipleHitAnyTargets());
        
        return platoon;
    }
}