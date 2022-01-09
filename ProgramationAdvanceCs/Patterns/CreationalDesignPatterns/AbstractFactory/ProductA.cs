namespace CreationalDesignPatterns.AbstractFactory
{
    public class ProductA : AbstractProductA
    {
        public override void Operation(AbstractProductB productB)
        {
            Console.WriteLine("ProductA.Operation(ProductB)");
        }
    }
}