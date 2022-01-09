using CreationalDesignPatterns.FactoryMethod;
using CreationalDesignPatterns.AbstractFactory;
using CreationalDesignPatterns.AbstractFactory.Malteada;
namespace factoryMethodPattern
{
        class Program
    {
        static void Main(string[] args)
        {
            // See https://aka.ms/new-console-template for more information
            // var creator = new ConcreteCreator();
            // var product = creator.FactoryMethod();
            // Console.WriteLine($"Product es del tipo: {product.GetType().Name}");

            // AbstractFactory factory = new ConcreteFactory();
            // Client client = new Client(factory);
            // client.Run();

            IFactory myFactory = new ChemicalFactory();
            myFactory.CreateProduct();

            IMilkProduct myMilk = myFactory.GetMilkProduct;
            IFlavourProduct myFlavour = myFactory.GetFlavour;

            myMilk.Production();
            myFlavour.Get();

            Console.WriteLine("Mi malteada es de {0} y {1}", 
                myMilk.GetInformation(), myFlavour.Information());
            Console.WriteLine("---------------------------------");

            myFactory = new NaturalFactory();
            myFactory.CreateProduct();

            myMilk = myFactory.GetMilkProduct;
            myFlavour = myFactory.GetFlavour;
            Console.WriteLine("Mi malteada es de {0} y {1}.",
                myMilk.GetInformation(), myFlavour.Information());

        }
    }
}
