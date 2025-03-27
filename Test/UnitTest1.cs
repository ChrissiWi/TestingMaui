using MauiDamageCalculator;

namespace Test;

[TestClass]
public class UnitTest1
{
    [DataRow(11, false, false, 14)]
    [DataRow(15, false, false, 18)]
    [DataRow(11, true, false, 22)]
    [DataRow(8, true, false, 17)]
    [DataRow(10, false, true, 15)]
    [DataRow(17, true, true, 34)]
    [TestMethod]
    public void TestSwordDamage(int roll, bool isMagic, bool isFlaming, int expected)
    {
        var swordDamage = new SwordDamage();
        swordDamage.CalculateDamage(roll, isMagic, isFlaming);
        Assert.AreEqual(expected, swordDamage.Damage);
    }

    [DataRow(10, false, false, 4)]  // 10 * 0.35 = 3.5, rounded up to 4
    [DataRow(15, false, false, 6)]  // 15 * 0.35 = 5.25, rounded up to 6
    [DataRow(10, true, false, 9)]   // (10 * 0.35 * 2.5) = 8.75, rounded up to 9
    [DataRow(15, true, false, 14)]  // (15 * 0.35 * 2.5) = 13.125, rounded up to 14
    [DataRow(10, false, true, 5)]   // (10 * 0.35 + 1.25) = 4.75, rounded up to 5
    [DataRow(15, false, true, 7)]   // (15 * 0.35 + 1.25) = 6.5, rounded up to 7
    [DataRow(10, true, true, 10)]   // ((10 * 0.35 * 2.5) + 1.25) = 10, rounded up to 10
    [DataRow(15, true, true, 15)]   // ((15 * 0.35 * 2.5) + 1.25) = 14.375, rounded up to 15
    [TestMethod]
    public void TestArrowDamage(int roll, bool isMagic, bool isFlaming, int expected)
    {
        var arrowDamage = new ArrowDamage();
        arrowDamage.Roll = roll;
        arrowDamage.Magic = isMagic;
        arrowDamage.Flaming = isFlaming;
        Assert.AreEqual(expected, arrowDamage.Damage);
    }
}