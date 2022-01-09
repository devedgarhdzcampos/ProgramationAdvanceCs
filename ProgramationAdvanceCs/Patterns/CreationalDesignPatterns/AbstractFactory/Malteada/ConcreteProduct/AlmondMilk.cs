namespace CreationalDesignPatterns.AbstractFactory.Malteada
{
    public class AlmondMilk : IMilkProduct
    {
        public void Production()
        {
            Console.WriteLine("Procesar las almendras");
        }

        public string GetInformation()
        {
            return "Leche organica de almendra, 250 ml";
        }
    }
}