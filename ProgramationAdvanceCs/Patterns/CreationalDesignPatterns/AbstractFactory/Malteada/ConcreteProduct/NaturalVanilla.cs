namespace CreationalDesignPatterns.AbstractFactory.Malteada
{
    public class NaturalVanilla : IFlavourProduct
    {
        public void Get()
        {
            Console.WriteLine("Se extrae de las vainas");
        }

        public string Information()
        {
            return "Extracto natural de vainilla";
        }
    }
}