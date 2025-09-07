namespace Task_11;

public class Platoon
{
    private List<Soldier> _soldiers = new List<Soldier>();
    public string name;

    public List<Soldier> GetSoldiers()
    {
        return _soldiers;
    }

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
        List<Soldier> deadSoldiers = new List<Soldier>();
        foreach (Soldier soldier in _soldiers)
        {
            if (soldier.Health <= 0)
            {
                deadSoldiers.Add(soldier);
            }
            // Ошибка, думаю можно сделать с циклом вайл и ремув по индексу
        }
        foreach (Soldier soldier in deadSoldiers)
        {
            _soldiers.Remove(soldier);
        }
    }
}