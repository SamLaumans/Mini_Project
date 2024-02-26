public class Player
{
    public int CurrentLocation ;
    public string Name ;
    public int CurrentWeapon ;
    public int MaxHealth ;
    public int CurrentHealth ;

    public Player(int currentLocation, string name, int currentWeapon, int maxHealth, int currentHealth)
    {
        CurrentLocation = currentLocation;
        Name = name;
        CurrentWeapon = currentWeapon;
        MaxHealth = maxHealth;
        CurrentHealth = currentHealth;
    }
}
