// Generics

// Generics allows us to work with different types

// Constraints in generics allows us to validate that a particular type should
// be of the specified constraint

namespace Generics
{
    // A generic class with a constraint that the class should be a value type
    public class Nullable<T> where T : struct
    {
        private object _value;

        public Nullable()
        {
        }

        public Nullable(T value)
        {
            _value = value;
        }

        public bool HasValue
        {
            get { return _value != null; }
        }

        public T GetValueOrDefault()
        {
            if (HasValue)
                return (T)_value;

            return default(T);
        }
    }
}


namespace Generics
{

    // Product(class) type constraint
    public class DiscountCalculator<TProduct> where TProduct : Product
    {
        public float CalculateDiscount(TProduct product)
        {
            return product.Price;
        }
    }
}

// where T : new() // intializing a object
// where T : class // reference type
// where T : IComparable // To a interface