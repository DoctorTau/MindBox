namespace MindBox
{
    public class Round : Figure
    {
        private double radius;
        public override double Area { get => area; }
        public Round(double radius)
        {
            this.radius = radius;
            this.area = Math.PI * Math.Pow(radius, 2);
        }
    }
}