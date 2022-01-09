namespace dotnet.Collections.Array
{
    using System.Collections;
    using ExtensionsMethods;
    public class PracticeBitArray : Abstract.IPracticeMain
    {
        public void Run()
        {
            BitArray bitArray = new BitArray(new byte[] {1,2,4,8,16});

            // Cantidad de elementos, 5 bytes * 8  = 40 bits
            Console.WriteLine(bitArray.Count);
            Console.WriteLine("--------------");
            bitArray.PrintList();

            // Obtenemos un bit en particular
            Console.WriteLine(bitArray.Get(2));

        
        }            
    }
}