namespace CreationalDesignPatterns.AbstractFactory
{
    public class Client
    {
        private readonly AbstractProductA _abstractProductA;
        private readonly AbstractProductB _abstractProductB;

        public Client(AbstractFactory factory)
        {
            _abstractProductA = factory.CreateProductA();
            _abstractProductB = factory.CreateProductB();
        }

        public void Run()
        {
            _abstractProductA.Operation(_abstractProductB);
            _abstractProductB.Operation(_abstractProductA);
        }
    }
}