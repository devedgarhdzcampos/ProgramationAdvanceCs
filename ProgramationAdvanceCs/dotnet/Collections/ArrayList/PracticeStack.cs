namespace dotnet.Collections.Array
{
    using ExtensionsMethods;
    public class PracticeStack : Abstract.IPracticeMain
    {
        int[] numbers = new int[] { 2, 4, 6, 8, 10 };
        public void Run()
        {
            // PILA: Ultimo en entrar primero en salir
            // LILO: Last In Last Out
            Stack<int> num = new Stack<int>();

            foreach (var item in numbers)
            {
                num.Push(item);
            }

            num.PrintList();

            foreach (var item in num)
            {
                Console.WriteLine(item);
            }

            // Eliminando elementos
            num.Pop();

            num.PrintList();
        }
    }
}