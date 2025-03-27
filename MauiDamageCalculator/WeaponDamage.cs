namespace MauiDamageCalculator;

public class WeaponDamage
{
    private int roll;
    private bool isMagic;
    private bool isFlaming;

    public bool Magic
    {
        get => isMagic;
        set {
            isMagic = value;
            CalculateDamage();
        }
    }

    public bool Flaming
    {
        get => isFlaming;
        set {
            isFlaming = value;
            CalculateDamage();
        }
    }
    public int Damage {get; protected set;}
   
     /// <summary>
    /// Returns the current roll value stored in the sword.
    /// </summary>
    /// <returns>The current roll value, or 0 if no roll has been performed yet</returns>
    public int Roll
    {
        get => roll;
        set {
            roll = value;
            CalculateDamage();
        }
    }

    /// <summary>
    /// Calculates the total damage of a sword attack based on the roll and enchantments
    /// </summary>
    /// <param name="roll">The base roll value from the attack</param>
    /// <param name="isMagic">Whether the sword is magical</param>
    /// <param name="isFlaming">Whether the sword has a flaming effect</param>
    /// <returns>The total calculated damage</returns>
    public virtual void CalculateDamage(){}
        
}