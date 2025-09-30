namespace Task_11;

public class Platoon
{
    private string _name;
    private List<Soldier> _soldiers = new List<Soldier>();
    
    public IReadOnlyList<Soldier> Soldiers => _soldiers;

    public string Name
    {
        get
        {
            if (!string.IsNullOrEmpty(_name))
            {
                return _name;
            }
            else
            {
                Console.WriteLine("Platoon Name is empty");
                return string.Empty;
            }
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                Console.WriteLine("Platoon Name is empty");
            }
            else
            {
                _name = value;
            }
        }
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
        _soldiers.RemoveAll(soldier => soldier.Health <= 0);
    }
}