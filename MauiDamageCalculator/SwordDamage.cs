using System.Diagnostics;

namespace MauiDamageCalculator;

/// <summary>
/// Represents a sword's damage calculation system that takes into account base damage,
/// magic enhancement, and flaming effects. The sword's damage is calculated using a
/// base damage value plus a multiplier applied to the roll, with additional modifiers
/// for magic and flaming effects.
/// </summary>
public class SwordDamage : WeaponDamage
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

    /// <summary>
    /// Calculates the total damage of a sword attack based on the current roll,
    /// magic status, and flaming status.
    /// </summary>
    public override void CalculateDamage()
    {
        CalculateDamage(Roll, Magic, Flaming);
    }

    /// <summary>
    /// Calculates the total damage of a sword attack using the specified parameters.
    /// The damage is calculated as: (roll * multiplier) + base damage + (flaming damage if applicable)
    /// where multiplier is 1.75 for magical swords and 1 for normal swords.
    /// </summary>
    /// <param name="roll">The base roll value from the attack</param>
    /// <param name="isMagic">Whether the sword is magical</param>
    /// <param name="isFlaming">Whether the sword has a flaming effect</param>
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

