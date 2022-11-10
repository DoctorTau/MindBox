namespace MindBox
{
    public class Round : Figure
    {
        private double radius;
        public override double Area { get => area; }
        public Round(double radius)
        {
            if (radius < 0)
                throw new FigureException("Radius can't be less than 0");

            this.radius = radius;
            this.area = Math.PI * Math.Pow(radius, 2);
        }
    }
}