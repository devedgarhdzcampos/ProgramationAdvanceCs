namespace CreationalDesignPatterns.AbstractFactory.Malteada
{
    using ExtensionsMethods;
    public class ChemicalFactory : IFactory
    {
        private IMilkProduct milk;
        private IFlavourProduct flavour;
        public IMilkProduct GetMilkProduct { get{ return milk; } }
        public IFlavourProduct GetFlavour { get{ return flavour; } }

        public void CreateProduct()
        {
            Console.WriteLine("Estamos produciendo tu malteada");
            milk = new CowMilk();
            flavour = new ChocolateFlavour();
        }
    }
}