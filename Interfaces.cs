// Interfaces


// An interface is simply a declaration of the capabilities (or services) that a class should provide.
// 1. Interface is purely a declaration
// 2. It helps building loosely coupled applications

// 3. Increases Extensibility(open and close principle)
// 4. Helps in Testability


// Testability
// A class that has tight dependencies to other classes cannot be isolated. 
//  To solve this problem, we use an interface. Here is an example:
public class OrderProcessor
{
    private IShippingCalculator _calculator;

    public Customer(IShippingCalculator calculator)
    {
        _calculator = calculator;
    }
}

public class ShowData : IDisplayData, ILogData
{

    // ShowData has some own functionality

    // Extending its Functionality without modification using multiple interface implementation.
}