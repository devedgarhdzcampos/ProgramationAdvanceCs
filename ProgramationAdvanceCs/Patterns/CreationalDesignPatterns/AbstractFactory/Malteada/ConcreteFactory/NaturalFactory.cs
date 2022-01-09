namespace CreationalDesignPatterns.AbstractFactory.Malteada
{
    using ExtensionsMethods;
    public class NaturalFactory : IFactory
    {
        private IMilkProduct milk;
        private IFlavourProduct flavour;
        public IMilkProduct GetMilkProduct { get{ return milk; } }
        public IFlavourProduct GetFlavour { get{ return flavour; } }

        public void CreateProduct()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string? selection = string.Empty;
            Console.WriteLine("Estamos creando la bebida");
            Console.WriteLine("1) Almendras, \n2) Coco");
            selection = Console.ReadLine();

            if (selection.EnsureNotNull() == "1")
                milk = new AlmondMilk();
            else
                milk = new CoconutMilk();
            
            milk.Production();

            Console.WriteLine("Ahora extraemos el sabor");
            flavour = new NaturalVanilla();
            flavour.Get();
        }
    }
}