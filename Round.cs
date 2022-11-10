namespace MindBox
{
    public class Round : Figure
    {
        private double radius;

        public override double Area { get => area; init => this.area = Math.PI * Math.Pow(radius, 2); }
        public Round(double radius)
        {
            this.radius = radius;
            this.Area = radius;
        }
    }
}