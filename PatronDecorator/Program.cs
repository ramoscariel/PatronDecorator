using PatronDecorator;

class Program
{
    static void Main(string[] args)
    {
        // Crear un café simple
        ICoffee simpleCoffee = new SimpleCoffee();
        Console.WriteLine($"Description: {simpleCoffee.GetDescription()}");
        Console.WriteLine($"Cost: {simpleCoffee.GetCost()}");

        // Añadir leche al café
        ICoffee milkCoffee = new MilkDecorator(simpleCoffee);
        Console.WriteLine($"\nDescription: {milkCoffee.GetDescription()}");
        Console.WriteLine($"Cost: {milkCoffee.GetCost()}");

        // Añadir azúcar al café con leche
        ICoffee sweetMilkCoffee = new SugarDecorator(milkCoffee);
        Console.WriteLine($"\nDescription: {sweetMilkCoffee.GetDescription()}");
        Console.WriteLine($"Cost: {sweetMilkCoffee.GetCost()}");
    }
}
