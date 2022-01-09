namespace dotnet.Collections.Array
{
    using System.Collections;
    using ExtensionsMethods;
    public class PracticeArrayList : Abstract.IPracticeMain
    {
        public void Run()
        {
            ArrayList words = new ArrayList();
            int n = 0; 
            int r = 0;

            //Podemos adicionar con rango
            words.AddRange(new string[] {"Esta", "es", "una", "cadena"});
            Console.WriteLine("La cantidad de elementos del ArrayList es {0}", words.Count);

            //Recorrer con el ciclo for
            words.PrintStringText();
            Console.WriteLine();
            Console.WriteLine("------------");

            // Agregar elementos en el arraylist
            words.Add(". Esto se agrego despues");

            // Recorrer por foreach
            foreach (var item in words)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
            Console.WriteLine("------------");

            // Agregando type cast
            ArrayList values = new ArrayList();
            values.Add(4);
            values.Add(5);
            values.Add(6);
            values.PrintList();
            Console.WriteLine("------------");

            // Validar si se encuentra un valor en el array list
            Console.WriteLine(values.Contains(4));
            Console.WriteLine(values.Contains(44));
            Console.WriteLine("------------");

            // Insertamos en un indice en particular
            values.Insert(2, 44);
            values.PrintList();
            Console.WriteLine("------------");

            // Remover
            values.Remove(44);
            values.PrintList();
            Console.WriteLine("------------");

            // Remover en la posición especifica
            values.RemoveAt(1);
            values.PrintList();
            Console.WriteLine("------------");
        }        
    }
}