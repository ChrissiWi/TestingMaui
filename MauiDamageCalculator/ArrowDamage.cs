namespace MauiDamageCalculator;

/// <summary>
/// Represents an arrow's damage calculation system that takes into account base damage,
/// magic enhancement, and flaming effects.
/// </summary>
public class ArrowDamage : WeaponDamage
{
    /// <summary>
    /// Base multiplier applied to the roll for normal attacks
    /// </summary>
    private const decimal BASE_MULTIPLIER = 0.35M;

    /// <summary>
    /// Enhanced multiplier applied to the roll when the arrow is magical
    /// </summary>
    private const decimal MAGIC_MULTIPLIER = 2.5M;

    /// <summary>
    /// Additional damage applied when the arrow has a flaming effect
    /// </summary>
    private const decimal FLAME_DAMAGE = 1.25M;

    /// <summary>
    /// Calculates the total damage of an arrow attack based on the roll and enchantments.
    /// The base damage is calculated as roll * 0.35, which is then modified by magic (2.5x multiplier)
    /// and flaming effects (adds 1.25 damage).
    /// </summary>
    public override void CalculateDamage()
    {
        decimal baseDamage = Roll * BASE_MULTIPLIER;
        if (Magic) baseDamage *= MAGIC_MULTIPLIER;
        if (Flaming) Damage = (int)Math.Ceiling(baseDamage + FLAME_DAMAGE);
        else Damage = (int)Math.Ceiling(baseDamage);
    }
    
}
