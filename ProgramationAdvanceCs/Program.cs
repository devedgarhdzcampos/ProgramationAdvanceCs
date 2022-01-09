using CreationalDesignPatterns.FactoryMethod;
using CreationalDesignPatterns.AbstractFactory;
using CreationalDesignPatterns.AbstractFactory.Malteada;
namespace factoryMethodPattern
{
        class Program
    {
        static void Main(string[] args)
        {
            Abstract.IPracticeMain obj = new dotnet.Collections.Array.PracticeBitArray();
            obj.Run();
        }
    }
}
