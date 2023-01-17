// Encapsulation : Binding data and methods in the class and exposing the data
// - through methods of the same class to other classes/fn()

// Advantages
/*
    - Increased flexibility
    - Data Hiding
    - Reusability
    - Testing code is easy
*/

// Encapsulation

static class Encapsulation
{
    // Encapsulating the data/ hiding the implementation
    private readonly string _name;


    // Exposing methods to handle data
    public void SetName(string name)
    {
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }


    // using automatic implemented property

    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            _name = value;
        }
    }
}

//////////////////////////////////////////////////////////
// INHERITANCE

// - A kind of relationship between two classes that allows one to inherit code from the 
// other. 
// - Referred to as Is-A relationship: A Car is a Vehicle
// - Benefits: code re-use and polymorphic behaviour. 
public class Car : Vehicle
{
}

////////////////////////////
// Composition

// - A kind of relationship that allows one class to contain another.
// - Referred to as Has-A relationship: A Car has an Engine

// - Benefits: Code re-use, flexibility and a means to loose-coupling

public class DbMigrator
{
    // We re-use the code in the logger class without 
    // the need to repeat that logic here in DbMigrator
    private Logger _logger;

    public DbMigrator(Logger logger)
    {
        _logger = logger;
    }

    public void anyMethod()
    {
        // making use of composition
        _logger.log();
    }
}

// Favour Composition over Inheritance 
// - Problems with inheritance:
// • Easily abused by amateur designers / developers
// • Leads to large complex hierarchies
// • Such hierarchies are very fragile and a change may affect many classes
// • Results in tight coupling 

// - Benefits of composition:
// • Flexible
// • Leads to loose coupling