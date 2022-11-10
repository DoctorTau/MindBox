namespace FigureServiceTest;

using MindBox;

[TestClass]
public class RoundServiceTest
{
    [TestMethod]
    public void AreaRound_10_314()
    {
        double radius = 10;
        double expected = 314.1592653589793;

        Round circle = new Round(radius);
        double actual = circle.Area;
        Assert.AreEqual(Math.Round(expected, 5), Math.Round(actual, 5));
    }

    // Add tests for Round
    [TestMethod]
    public void AreaRound_0_0()
    {
        double radius = 0;
        double expected = 0;

        Round circle = new Round(radius);
        double actual = circle.Area;
        Assert.AreEqual(Math.Round(expected, 5), Math.Round(actual, 5));
    }
    [TestMethod]
    public void AreaRound_1_Pi()
    {
        double radius = 1;
        double expected = 3.14159;

        Round circle = new Round(radius);
        double actual = circle.Area;
        Assert.AreEqual(Math.Round(expected, 5), Math.Round(actual, 5));
    }

    [TestMethod]
    public void AreaRound_2_12()
    {
        double radius = 2;
        double expected = 12.56637;

        Round circle = new Round(radius);
        double actual = circle.Area;
        Assert.AreEqual(Math.Round(expected, 5), Math.Round(actual, 5));
    }
}