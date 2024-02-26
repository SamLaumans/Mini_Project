public class Player
{
    public int CurrentLocation ;
    public string Name ;
    public int CurrentWeapon ;
    public int Attack ;
    public int Defense ;

    public Player(int CurrentLocation, string name, int CurrentWeapon, int MaxHealth, int CurrentHealth)
    {
        CurrentLocation = CurrentLocation;
        Name = name;
        CurrentWeapon = CurrentWeapon;
        MaxHealth = MaxHealth;
        CurrentHealth = CurrentHealth;
    }
}
