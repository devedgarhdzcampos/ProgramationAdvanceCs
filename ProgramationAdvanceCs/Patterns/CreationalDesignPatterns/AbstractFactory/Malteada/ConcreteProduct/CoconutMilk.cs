namespace CreationalDesignPatterns.AbstractFactory.Malteada
{
    public class CoconutMilk : IMilkProduct
    {
        public void Production()
        {
            Console.WriteLine("Buscamos los cocos");
        }

        public string GetInformation()
        {
            return "Leche de coco natural, 250 ml";
        }
    }
}