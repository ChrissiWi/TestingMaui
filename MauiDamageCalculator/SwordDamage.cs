using System.Diagnostics;

namespace MauiDamageCalculator;

/// <summary>
/// Represents a sword's damage calculation system that takes into account base damage,
/// magic enhancement, and flaming effects.
/// </summary>
public class SwordDamage
{
    /// <summary>
    /// Base damage that is always applied to the sword's attack
    /// </summary>
    private const int BASE_DAMAGE = 3;

    /// <summary>
    /// Additional damage applied when the sword has a flaming effect
    /// </summary>
    private const int FLAME_DAMAGE = 2;

    /// <summary>
    /// Base multiplier applied to the roll for normal attacks
    /// </summary>
    private const decimal BASE_MULTIPLIER = 1;

    /// <summary>
    /// Enhanced multiplier applied to the roll when the sword is magical
    /// </summary>
    private const decimal MAGIC_MULTIPLIER = 1.75M;

    private int roll;
    private bool isMagic;
    private bool isFlaming;

    public int Damage {get; private set;}
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

    /// <summary>
    /// Calculates the total damage of a sword attack based on the roll and enchantments
    /// </summary>
    /// <param name="roll">The base roll value from the attack</param>
    /// <param name="isMagic">Whether the sword is magical</param>
    /// <param name="isFlaming">Whether the sword has a flaming effect</param>
    /// <returns>The total calculated damage</returns>
    public void CalculateDamage()
    {
        CalculateDamage(roll, isMagic, isFlaming);
    }


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


    //also used in Test -> roll is the input parameter
    public void CalculateDamage(int roll, bool isMagic, bool isFlaming)
    {
        Debug.WriteLine($"Calculating damage with roll: {roll}, isMagic: {isMagic}, isFlaming: {isFlaming}");
        
        // Apply the appropriate multiplier based on whether the sword is magical
        decimal multiplier = isMagic ? MAGIC_MULTIPLIER : BASE_MULTIPLIER;
        
        // Calculate base damage: (roll * multiplier) + base damage
        Damage = (int)(roll * multiplier) + BASE_DAMAGE;
        
        // Add flaming damage if the sword has the flaming effect
        if (isFlaming)
        {
            Damage += FLAME_DAMAGE;
        }
    }
  
}

