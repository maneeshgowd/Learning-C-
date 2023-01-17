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

//====== Diff class Vs Static class Vs Abstract class

/*

*/