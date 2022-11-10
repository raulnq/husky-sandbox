using calculator;

namespace tests;

[TestClass]
public class CalculatorTests
{
    [TestMethod]
    [DataRow(1, 2, 3)]
    public void sum_X_and_Y_should_be_Z(int x, int y, int z)
    {
        var sut = new Calculator();

        var r = sut.Sum(x, y);

        Assert.AreEqual(z, 1);
    }
}