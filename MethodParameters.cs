namespace PractiseApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int valType = 0;
            int refType = 0;
            int sum, prod;

            ValueType(valType); // Copy of var is passed (No changes)
            RefType(ref refType); // Acutal address(reference) of var is passed (Changes will be made)
            OutType(10,20,out sum, out prod); // Similar to ref but used when we want to return multiple values from a function
            ParamType(1,2,3,4,5); // Similar to Rest pattern in JS (combines individual data into a List/Collection)
        }

        static void ValueType(int i)
        {
            i = 10;
        }

        static void RefType(ref int i)
        {
            i = 20;
        }

        static void OutType(int i, int j, out int sum, out int prod)
        {
            sum = i + j;
            prod = i * j;
        }

        static void ParamType(params int[] nums)
        {
            foreach (var i in nums)
            {
                Console.WriteLine(i);
            }
        }
    }
}