namespace CreationalDesignPatterns.AbstractFactory
{
    public class ProductB : AbstractProductB
    {
        public override void Operation(AbstractProductA productA)
        {
            Console.WriteLine("ProductB.Operation(ProductA)");
        }
    }
}