namespace InterfacesApp.Models.Base;

class Hero : ITest
{
    public string Name { get; set; }
    public double Attack { get; set; }

    public void Method2() { }
}