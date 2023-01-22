// Classes and types od classes in C#

// Regular classes

class Random
{
    public int age = 20; // Data member (state)

    // readonly fields can be assigned only once, either at declaration or in constructor.
    public readonly int data = 100;
    public void showAge() // Method (acts upon state)
    {
        Console.WriteLine("My age is {0}", age);
    }
}

// INSTANCE => Random r = new Random();

// Static class/types

static class Random
{
    public static int age = 20;

    public static void showAge()
    {
        Console.WriteLine("My age is {0}", age);
    }
}

// INSTANCE => Random.showAge()

// Abstract class
// Useful when we want to provide common functionality but that need to be overridden
// Forces the derived class to override members.
abstract class Abstract
{
    public int x = 10;
    public abstract void Calculate();
}

//====== Diff class Vs Static class Vs Abstract class

/*
    - Regular classes

        1. Can be Instantiated
        2. Can have static members
        3. Supports Inheritance

    - Static classes
        
        1. Cannot be Instantiated
        2. Can only have static members
        3. NO Inheritance
        4. No overloading / overriding
        4. No this keyword

    - Abstract classes

        1. Cannot be Instantiated
        2. Abstract members need to be overridden
        3. Can contains regular and abstract methods

*/