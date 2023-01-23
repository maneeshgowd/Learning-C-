// A predicate is a delegate which returns a boolean value.


static void Main()
{
    // List declared with object-initiazlier syntax
    List<int> arr = new List<int> { 1, 2, 3, 4, 5 };

    // Below method expects a predicate (A function) that would be called for each
    // item in the list and matches the below condition and returns a list of true items.


    // Using Lambda expression (JS arrow function)
    List<int> list = arr.FindAll(item => item > 3);
}