// Constructor Inheritance allows us to call extended class constructor
// - In the derived class using base method()

public class Base
{
    public Base(string val)
    {
        Console.WriteLine("Base class, {0}", val);
    }
}

public class Derived : Base
{

    // Calling the base class constructor then current class ctor
    public Derived(string val) : base(val)
    {
        Console.WriteLine("Derived class {0}", val);
    }
}