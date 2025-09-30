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
        ShowSoldiersCountInPlatoon(platoon1);
        ShowSoldiersCountInPlatoon(platoon2);
    }

    public static void ShowSoldiersCountInPlatoon(Platoon platoon)
    {
        IReadOnlyList<Soldier> soldiersInPlatoon = platoon.Soldiers;
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
        Console.WriteLine(platoon.Name);
        Console.WriteLine($"Soldiers1: {countSoldiers1}");
        if (countSoldiers2 > 0)
            Console.WriteLine($"Soldiers2: {countSoldiers2}");
        if (countSoldiers3 > 0)
            Console.WriteLine($"Soldiers3: {countSoldiers3}");
        if (countSoldiers4 > 0)
            Console.WriteLine($"Soldiers4: {countSoldiers4}");
        Console.WriteLine(new string('-', 30));
    }

    public static void StartFight(Platoon platoon1, Platoon platoon2)
    {
        platoon1.BeginAttack(platoon2);
        platoon2.BeginAttack(platoon1);
    }

    public static void RestAfterBattle(Platoon platoon1, Platoon platoon2)
    {
        platoon1.CheckAndRemoveDeadSoldiers();
        platoon2.CheckAndRemoveDeadSoldiers();
    }

    public static void StartBattle(Platoon platoon1, Platoon platoon2)
    {
        while (platoon1.Soldiers.Count != 0 && platoon2.Soldiers.Count != 0)
        {
            StartFight(platoon1, platoon2);
            RestAfterBattle(platoon1, platoon2);
        }

        if (platoon1.Soldiers.Count == 0)
        {
            Console.WriteLine("Platoon 2 won!");
        }

        if (platoon2.Soldiers.Count == 0)
        {
            Console.WriteLine("Platoon 1 won!");
        }

        if (platoon1.Soldiers.Count == 0 && platoon2.Soldiers.Count == 0)
        {
            Console.WriteLine("");
        }
    }
}