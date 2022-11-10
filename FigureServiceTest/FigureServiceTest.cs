namespace FigureServiceTest;

using MindBox;

[TestClass]
public class FigureServiceTest
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

    [TestMethod]
    public void AreaTriangle_3_4_5_6()
    {
        double sideA = 3;
        double sideB = 4;
        double sideC = 5;
        double expected = 6;

        Triangle triangle = new Triangle(sideA, sideB, sideC);
        double actual = triangle.Area;
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void IsRightTriangle_3_4_5_true()
    {
        double sideA = 3;
        double sideB = 4;
        double sideC = 5;
        bool expected = true;

        Triangle triangle = new Triangle(sideA, sideB, sideC);
        bool actual = triangle.IsRightTriangle();
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void IsRightTriangle_3_4_6_false()
    {
        double sideA = 3;
        double sideB = 4;
        double sideC = 6;
        bool expected = false;

        Triangle triangle = new Triangle(sideA, sideB, sideC);
        bool actual = triangle.IsRightTriangle();
        Assert.AreEqual(expected, actual);
    }
}