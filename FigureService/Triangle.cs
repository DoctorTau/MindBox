namespace MindBox;

/// <summary>
/// Represents a triangle figure.
/// </summary>
public class Triangle : Figure
{
    // Variables to store the length of each side of the triangle
    private double sideA;
    private double sideB;
    private double sideC;

    /// <summary>
    /// Gets the area of the triangle.
    /// </summary>
    public override double Area
    {
        get => area;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Triangle"/> class.
    /// </summary>
    /// <param name="sideA">The length of the first side of the triangle.</param>
    /// <param name="sideB">The length of the second side of the triangle.</param>
    /// <param name="sideC">The length of the third side of the triangle.</param>
    /// <exception cref="FigureException">Thrown when one of the sides is less than 0, 
    /// or the sum of any two sides is not greater than the third side.</exception>
    public Triangle(double sideA, double sideB, double sideC)
    {
        if (sideA < 0 || sideB < 0 || sideC < 0)
            throw new FigureException("Side can't be less than 0");
        if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
            throw new FigureException("The sum of any two sides must be greater than the third side");

        this.sideA = sideA;
        this.sideB = sideB;
        this.sideC = sideC;
        this.area = Math.Sqrt((sideA + sideB + sideC)
        * (sideA + sideB - sideC)
        * (sideA - sideB + sideC)
        * (-sideA + sideB + sideC)) / 4;
    }

    /// <summary>
    /// Determines whether the triangle is a right-angled triangle.
    /// </summary>
    /// <returns><c>true</c> if the triangle is a right-angled triangle; otherwise, <c>false</c>.</returns>
    public bool IsRightTriangle()
    {
        // Calculate the squares of the sides
        double squareA = sideA * sideA,
               squareB = sideB * sideB,
               squareC = sideC * sideC;

        // Compare sums of two sides
        return squareA == squareB + squareC || squareB == squareA + squareC || squareC == squareA + squareB;
    }
}
