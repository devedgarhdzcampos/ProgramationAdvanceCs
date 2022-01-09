namespace CreationalDesignPatterns.AbstractFactory.Malteada
{
    public class ChocolateFlavour : IFlavourProduct
    {
        public void Get()
        {
            Console.WriteLine("Se proeduce C7H8N402");
        }

        public string Information()
        {
            return "Sabor a chocolate";
        }
    }
}