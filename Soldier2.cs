namespace Task_11;

public class Soldier2 : Soldier
{
    private readonly double _damageMultiplier = 1.5;
    
    public Soldier2() : base("Improved_Soldier_damageMultiplier", 80, 20, 5,1)
    { }

    protected override void DealDamage(Soldier enemySoldier)
    {
        double damageDone = Damage * _damageMultiplier;
        ApplyDamageTo(enemySoldier, damageDone);
    }
}