namespace Task_11;

public class Platoon
{
    public string Name;
    private List<Soldier> _soldiers = new List<Soldier>();
    
    public IReadOnlyList<Soldier> Soldiers => _soldiers;

    public void AddSoldier(Soldier soldier)
    {
        _soldiers.Add(soldier);
    }

    public void BeginAttack(Platoon enemyPlatoon)
    {
        int i = 0;
        foreach (Soldier soldier in _soldiers)
        {
            i++;
            soldier.Attack(enemyPlatoon);
            //Console.WriteLine($"\nСолдат {i} атаковал!");
            // Вывод от атакующего
        }
    }

    public void CheckAndRemoveDeadSoldiers()
    {
        _soldiers.RemoveAll(soldier => soldier.Health <= 0);
    }
}