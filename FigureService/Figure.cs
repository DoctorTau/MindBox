namespace MindBox;

/// <summary>
/// An abstract class representing a geometrical figure.
/// </summary>
public abstract class Figure
{
    /// <summary>
    /// The area of the figure.
    /// </summary>
    protected double area;

    /// <summary>
    /// Gets the area of the figure. This property must be implemented by derived classes.
    /// </summary>
    public abstract double Area { get; }
}
