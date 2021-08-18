using System;

namespace RiderBug2021._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Example {
        private Payload _value;

        public Payload Value {
            get => _value is DerivedPayload ? throw new InvalidOperationException() : _value;
            set => _value = value;
        }
    }

    class Payload {

    }

    class DerivedPayload : Payload {

    }
}
