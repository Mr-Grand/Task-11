namespace Task_11;

public class Soldier
{
    public readonly string Id;
    protected double Damage;
    protected readonly int Armour;
    protected int TargetCount;
    
    public int Health { get; private set; }

    public Soldier(string id, int health, double damage, int armour, int targetCount)
    {
        Id = id;
        Health = health;
        Damage = damage;
        Armour = armour;
        TargetCount = targetCount;
    }

    public virtual void Attack(Platoon enemyPlatoon)
    {
        var enemyPlatoonSoldiers = ChooseTarget(enemyPlatoon.Soldiers);
        foreach (var soldier in enemyPlatoonSoldiers)
        {
            this.DealDamage(soldier);
        }
    }

    protected void ApplyDamageTo(Soldier target, double amount)
    {
        target.TakeDamage(amount);
    }

    protected virtual void DealDamage(Soldier enemySoldier)
    {
        double damageDone = Damage;
        ApplyDamageTo(enemySoldier, damageDone);
    }

    protected virtual void TakeDamage(double damage)
    {
        int checkDamage = Math.Max(0, (int)Math.Round(damage - Armour));
        Health -= checkDamage;
    }

    protected virtual List<Soldier> ChooseTarget(IReadOnlyList<Soldier> soldiers)
    {
        List<Soldier> choosenSoldiers = new List<Soldier>();
        for (int i = 0; i < TargetCount; i++)
        {
            int randomTarget = RandomClass.Random.Next(0, soldiers.Count);
            //Console.Write(randomTarget+1);
            // Вывод выбранной цели для атаки
            choosenSoldiers.Add(soldiers[randomTarget]);
        }
        return choosenSoldiers;
    }
}