using System;
namespace PatronDecorator
{
    public class SugarDecorator : ICoffeeDecorator
    {
        private readonly ICoffee _coffee;

        public SugarDecorator(ICoffee coffee)
        {
            _coffee = coffee;
        }

        public string GetDescription()
        {
            return _coffee.GetDescription() + ", Sugar";
        }

        public double GetCost()
        {
            return _coffee.GetCost() + 0.2;
        }
    }
}

