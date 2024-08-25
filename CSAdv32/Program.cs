using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSAdv32
{
    class Wanted<T>  // Generic 
    {
        public T Value;
        public Wanted(T value)
        {
            Value = value;
        }
    }
    class Needed<T, U> // Generic
    {
        public T Value1;
        public U Value2;
        public Needed(T value1, U value2)
        {
            Value1 = value1;
            Value2 = value2;
        }
    }
    class SpecialNeeded<T, U> // Generic
        where T : IComparable
        where U : IComparable, IDisposable
    {
        public T Value1;
        public U Value2;
        public SpecialNeeded(T value1, U value2)
        {
            Value1 = value1;
            Value2 = value2;
        }
    }

    class SquareCalculator
    {
        public int this[int i] // Indexer
        {
            get { return i * i; }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Wanted<int> wantedInt = new Wanted<int>(65535);
            Wanted<string> wantedString = new Wanted<string>("Hello, World!");
            Wanted<double> wantedDouble = new Wanted<double>(3.14159);
            Console.WriteLine(wantedInt.Value);
            Console.WriteLine(wantedString.Value);
            Console.WriteLine(wantedDouble.Value);

            SquareCalculator s = new SquareCalculator();
            Console.WriteLine(s[256]);
        }
    }
}