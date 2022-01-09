namespace CreationalDesignPatterns.AbstractFactory.Malteada
{
    public class MalteadaFactoryMain
    {
        public void MalteadaMain()
        {
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