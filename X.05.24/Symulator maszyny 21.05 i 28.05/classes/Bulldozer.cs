namespace _21._05.classes
{
  internal class Bulldozer : Machine
  {
    public Bulldozer(string name, MachineType type) : base(name, type)
    {
      
    }

    public Bulldozer(Bulldozer bulldozer) : base(bulldozer)
    {
      
    }

    ~Bulldozer()
    {
      Console.WriteLine($"Spychacz {Name} został zniszczony");
    }

    public override void Start()
    {
      base.Start();
      Console.WriteLine($"{Name} rozpoczyna równanie terenu");
    }

    //symulacja równania terenu
    public void Flatten()
    {
      Console.WriteLine($"{Name} równa teren");
    }

    public override void Work()
    {
      Flatten();
    }
  }
}
