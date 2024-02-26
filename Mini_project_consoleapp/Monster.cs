public class Monster
{
    public int ID ;
    public string Name ;
    public int CurrentHealth ;
    public int MaxHealth ;
    public int Attack ;
    public int Defense ;

    public Monster(int id, string name, int currenthealth, int maxhealth, int attack, int defense)
    {
        ID = id;
        Name = name;
        CurrentHealth = currenthealth;
        MaxHealth = maxhealth;
        Attack = attack;
        Defense = defense;
    }
}
