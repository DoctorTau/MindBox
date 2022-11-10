namespace FigureServiceTest;
using MindBox;

[TestClass]
public class TriangleServiceTest
{
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