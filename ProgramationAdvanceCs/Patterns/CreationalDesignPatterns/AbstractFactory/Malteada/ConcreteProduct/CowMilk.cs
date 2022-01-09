namespace CreationalDesignPatterns.AbstractFactory.Malteada
{
    public class CowMilk : IMilkProduct
    {
        public void Production()
        {
            Console.WriteLine("Ordeñar vaca en la granja");
        }

        public string GetInformation()
        {
            return "Leche de vaca, 250 ml";
        }
    }
}