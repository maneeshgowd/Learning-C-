// Upcasting

// Conversion from a derived class to a base class (Implicit)
public class Shape
{
    public int Width { get; set; }
    public int Height { get; set; }
}

public class Text : Shape
{
    public int FontSize { get; set; }
    public int FontShape { get; set; }
}

class Program
{
    public void UpCasting()
    {
        // Both objects points to the same memory location 
        Text text = new Text();
        // Has limited acess (can't access text members)
        Shape shape = text;
    }
}

// Downcasting

// Conversion from a base class to a derived class (Explicit)

// Type is known at Runtime for both Upcasting and DownCasting

class Program
{
    public void Downcasting()
    {
        // Has limited acess (can't access text members)
        Shape shape = new Text();
        // Downcasting
        Text text = (Text)shape;
        // Get's access of both text and shape members;


        // Casting can throw an exception if the conversion is not successful. We can use the as 
        // keyword to prevent this. If conversion is not successful, null is returned. 
        // While Downcasting if you are not known about the type of an object we use (as) keyword

        var text = shape as Text;

        if (text != null)
        {
            // Do something
        }

        // (is) keyword to check whether an object belongs to a particular type

        if (shape is Shape)
        {
            // Do something..
        }
    }
}