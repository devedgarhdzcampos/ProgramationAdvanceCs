namespace CreationalDesignPatterns.AbstractFactory.Malteada
{
    public interface IFactory
    {
        public IMilkProduct GetMilkProduct { get; }
        public IFlavourProduct GetFlavour { get; }
        public void CreateProduct();
    }
}