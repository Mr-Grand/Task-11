namespace Task_11;

class Program
{
    static void Main(string[] args)
    {
        PlatoonFactory platoonFactory = new PlatoonFactory();
        Platoon platoon1 = platoonFactory.CreateSoldiers();
        Platoon platoon2 = platoonFactory.CreateSoldiers();
        
        ShowSoldiersCountInPlatoon(platoon1);
        ShowSoldiersCountInPlatoon(platoon2);
        
        StartBattle(platoon1, platoon2);
        RestAfterBattle(platoon1, platoon2);

        Console.WriteLine();
        
        
    }

    public static void ShowSoldiersCountInPlatoon(Platoon platoon)
    {
        IReadOnlyList<Soldier> soldiersInPlatoon = platoon.GetSoldiers();
        int countSoldiers1 = 0;
        int countSoldiers2 = 0;
        int countSoldiers3 = 0;
        int countSoldiers4 = 0;
        
        foreach (Soldier soldier in soldiersInPlatoon)
        {
            if (soldier.Id == "Common_Soldier")
                countSoldiers1++;
            if (soldier.Id == "Improved_Soldier_damageMultiplier") 
                countSoldiers2++;
            if (soldier.Id == "Improved_Soldier_SeveralNonrepeatableTargets")
                countSoldiers3++;
            if (soldier.Id == "Improved_Soldier_SeveralRepeatableTargets")
                countSoldiers4++;
        }
        
        Console.WriteLine(new string('-', 30));
        Console.WriteLine($"Soldiers1: {countSoldiers1}");
        if(countSoldiers2 > 0)
            Console.WriteLine($"Soldiers2: {countSoldiers2}");
        if(countSoldiers3 > 0)
            Console.WriteLine($"Soldiers3: {countSoldiers3}");
        if(countSoldiers4 > 0)
            Console.WriteLine($"Soldiers4: {countSoldiers4}");
    }

    public static void StartBattle(Platoon platoon1, Platoon platoon2)
    {
        
        platoon1.BeginAttack(platoon2);
        platoon2.BeginAttack(platoon1);
    }

    public static void RestAfterBattle(Platoon platoon1, Platoon platoon2)
    {
        platoon1.CheckAndRemoveDeadSoldiers();
        platoon2.CheckAndRemoveDeadSoldiers();
    }
}