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
}