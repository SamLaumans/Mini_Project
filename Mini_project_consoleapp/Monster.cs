public class Monster
{
    public int Id ;
    public string Name ;
    public int CurrentHealth ;
    public int Attack ;
    public int Defense ;

    public Monster(int id, string name, int CurrentHealth, int MaxHealth, int attack, int defense)
    {
        Id = id;
        Name = name;
        CurrentHealth = CurrentHealth;
        MaxHealth = MaxHealth;
        Attack = attack;
        Defense = defense;
    }
}
