namespace MindBox;
public class Triangle : Figure
{
    private double sideA;
    private double sideB;
    private double sideC;

    public override double Area
    {
        get => area;
    }
    public Triangle(double sideA, double sideB, double sideC)
    {
        this.sideA = sideA;
        this.sideB = sideB;
        this.sideC = sideC;
        this.area = Math.Sqrt((sideA + sideB + sideC)
        * (sideA + sideB - sideC)
        * (sideA - sideB + sideC)
        * (-sideA + sideB + sideC)) / 4;
    }
}