namespace _21._05.classes
{
  internal class Crane : Machine
  {
    public Crane(string name, MachineType type) : base(name, type)
    {
    }

    public Crane(Crane crane) : base(crane)
    {

    }

    ~Crane()
    {
      Console.WriteLine($"Dźwig {Name} został zniszczony");
    }

    public override void Start()
    {
      base.Start();
      Console.WriteLine($"{Name} rozpoczyna podnoszenie ładunku");
    }

    //metoda symulująca podnoszenie ładunku
    public void Lift()
    {
      Console.WriteLine($"{Name} podnosi ładunek");
    }

    public override void Work()
    {
      Lift();
    }
  }
}
