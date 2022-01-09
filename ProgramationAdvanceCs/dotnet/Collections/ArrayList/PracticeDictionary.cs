namespace dotnet.Collections.Array
{
    public class PracticeDictionary : Abstract.IPracticeMain
    {
        public void Run()
        {
            Dictionary<string,int> edades = new Dictionary<string, int>();

            // Llenar un diccionario
            edades.Add("Juan", 18);
            edades.Add("Diana", 35);
            edades["María"]=25;
            edades["Antonio"] = 48;

            // Recorrer diccionario 
            foreach (var item in edades)
            {
                Console.WriteLine("Nombre: {0}\nEdad: {1}\n", item.Key, item.Value);
            }
        }        
    }
}