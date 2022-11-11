using calculator;

namespace tests;

[TestClass]
public class CalculatorTests
{
    [TestMethod]
    [TestCategory("Fast")]
    public void sum_1_and_2_should_be_3()
    {
var sut = new Calculator();

        var r = sut.Sum(1, 2);

        Assert.AreEqual(3, r);
    }

    [TestMethod]
    [TestCategory("Slow")]
    [DataRow(1, 2, 3)]
    [DataRow(2, 2, 4)]
    [DataRow(0, 0, 0)]
    [DataRow(-1, 1, 0)]
    public void sum_X_and_Y_should_be_Z(int x, int y, int z)
    {
        var sut = new Calculator();

        var r = sut.Sum(x, y);

        Assert.AreEqual(z, r);
    }
}
