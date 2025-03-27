namespace MauiDamageCalculator;

/// <summary>
/// Base class for weapon damage calculation that provides common functionality
/// for tracking roll values, magic status, flaming status, and damage calculation.
/// </summary>
public class WeaponDamage
{
    private int roll;
    private bool isMagic;
    private bool isFlaming;

    /// <summary>
    /// Gets or sets whether the weapon is magical. Setting this property
    /// automatically triggers a damage recalculation.
    /// </summary>
    public bool Magic
    {
        get => isMagic;
        set {
            isMagic = value;
            CalculateDamage();
        }
    }

    /// <summary>
    /// Gets or sets whether the weapon has a flaming effect. Setting this property
    /// automatically triggers a damage recalculation.
    /// </summary>
    public bool Flaming
    {
        get => isFlaming;
        set {
            isFlaming = value;
            CalculateDamage();
        }
    }

    /// <summary>
    /// Gets the calculated damage value. This property is protected to allow
    /// derived classes to set its value during damage calculation.
    /// </summary>
    public int Damage {get; protected set;}
   
    /// <summary>
    /// Gets or sets the current roll value. Setting this property automatically
    /// triggers a damage recalculation.
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
    /// Calculates the total damage of a weapon attack based on the roll and enchantments.
    /// This is a virtual method that should be overridden by derived classes to implement
    /// their specific damage calculation logic.
    /// </summary>
    public virtual void CalculateDamage(){}
}