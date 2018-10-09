namespace di_002_approaches
{
    public interface IPart {
        string Name { get; set; }
        double Price { get; set; }
    }

    public class Wheel: IPart
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }

    public class Engine: IPart
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
}