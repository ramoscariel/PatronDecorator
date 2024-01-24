using System;
namespace PatronDecorator
{
	public class MilkDecorator : ICoffeeDecorator
    {
        private readonly ICoffee _coffee;

        public MilkDecorator(ICoffee coffee)
        {
            _coffee = coffee;
        }

        public string GetDescription()
        {
            return _coffee.GetDescription() + ", Milk";
        }

        public double GetCost()
        {
            return _coffee.GetCost() + 0.5;
        }
    }
}

