namespace Task_11;

public class SoldierMultipleHitDifferentTargets : Soldier
{
    public SoldierMultipleHitDifferentTargets() : base("Improved_Soldier_SeveralNonrepeatableTargets", 60, 15, 5, 3)
    { }

    protected override List<Soldier> ChooseTarget(IReadOnlyList<Soldier> soldiers)
    {
        List<Soldier> choosenSoldiers = new List<Soldier>();
        List<int> choosenTargets = new List<int>();
        int i = 1;
        int randomTarget = 0;
        while (i <= TargetCount)
        {
            randomTarget = RandomClass.Random.Next(0, soldiers.Count);
            if (!choosenTargets.Contains(randomTarget))
            {
                //Console.Write($"{randomTarget+1} ");
                // Вывод выбранной цели для атаки
                choosenSoldiers.Add(soldiers[randomTarget]);
                choosenTargets.Add(randomTarget);
                i++;
            }
        }
        return choosenSoldiers;
    }
}