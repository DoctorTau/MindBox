namespace MindBox
{
    /// <summary>
    /// A class that represents a round figure.
    /// </summary>
    public class Round : Figure
    {
        // This private field stores the value of the circle's radius.
        private double radius;
        
        // This property overrides the abstract Area property from the parent class Figure.
        // It calculates the area of the circle (pi times radius squared) and returns it.
        public override double Area { get => area; }
        

        /// <summary>
        /// Instantiates a new round object with the given radius value.
        /// </summary>
        /// <param name="radius">The radius of the round.</param>
        /// <exception cref="FigureException">Thrown when the radius is less than 0.</exception>
        public Round(double radius)
        {
            if (radius < 0)
                throw new FigureException("Radius can't be less than 0");

            this.radius = radius;
            this.area = Math.PI * Math.Pow(radius, 2);
        }
    }

}