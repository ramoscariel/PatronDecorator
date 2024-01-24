using System;
namespace PatronDecorator
{
	public class SimpleCoffee : ICoffee
    {
        public string GetDescription()
        {
            return "Simple Coffee";
        }

        public double GetCost()
        {
            return 2.0;
        }
    }
}

