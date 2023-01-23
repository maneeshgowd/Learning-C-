// Delegates

// An object that knows how to call a method (or a group or methods)
// In simple terms (A reference to a function)




namespace random
{

    public delegate void Delegate(string str);


    class any
    {
        public void showData(string str)
        {
            System.Console.WriteLine(str);
        }
        public void hideData(string str)
        {
            System.Console.WriteLine(str);
        }

        public int funDelegate(int num)
        {
            // do something
        }

        static void Main()
        {

            // our own delegate
            // Can return value
            Delegate d = ShowData;
            d += hideData;
            d.Invoke("hii");

            // Built-in Action delegate
            // A delegate which takes string has arg and but dosen't return any value
            // This type of delegates dosen't return any value
            Action<string> ac = ShowData;


            // Action delegate using lambda expression
            Action<string> ac = str => ShowData(str);
            ac.Invoke("hello");

            //////////////////////////////////////////////////
            // Built-in Func delegate
            // A delegate which takes generic type of args and return some generic value;
            // Below delegate take int param and return int
            Func<int, int> funD = funDelegate;
        }
    }
}

// Use cases

// For designing extensible and flexible applications

// An eventing design pattern is used
// The caller dosen't need to access other properties or methods on 
// - the object implementing the method