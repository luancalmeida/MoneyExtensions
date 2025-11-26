namespace MoneExtension.Tests;

[TestClass]
public sealed class Test1
{
    [TestMethod]
    public void TestMethod1()
    {
        decimal money = 12.34m;
        int cents = money.ToCents();
        Assert.AreEqual(1234, cents);
    }
}
