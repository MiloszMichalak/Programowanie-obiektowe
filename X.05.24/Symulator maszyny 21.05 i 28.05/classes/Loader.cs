namespace _21._05.classes
{
  internal class Loader : Machine
  {
    public Loader(string name, MachineType type) : base(name, type)
    {
    }

    public Loader(Loader loader) : base(loader) { }

    ~Loader()
    {
      Console.WriteLine($"Ładowarka {Name} została zniszczona");
    }

    public override void Start()
    {
      base.Start();
      Console.WriteLine($"{Name} rozpoczyna ładowanie materiałów");
    }

    public void Load()
    {
      Console.WriteLine($"{Name} ładuje materiały");
    }

    public override void Work()
    {
      Load();
    }
  }
}
