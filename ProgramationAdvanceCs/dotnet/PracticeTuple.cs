namespace dotnet
{
    public class PracticeTuple
    {
        public void TupleMain()
        {
            // Las tuplas nos permiten guardar multiples valores en una sola unidad
            // muy utiles para regresar mucho valores sin tener que usar out

            //Creamos una tupla
            Tuple<string, int> myTupleComplete = new Tuple<string, int>("Hola", 57);
            var myTupleSmall = ("Hola", 60);

            //Mostrar contenido
            Console.WriteLine("Contenido de mi tupla completa: {0} : {1}",myTupleComplete.Item1, myTupleComplete.Item2);
            Console.WriteLine("Contenido de mi tupla corta: {0} : {1}", myTupleSmall.Item1, myTupleSmall.Item2);
            Console.WriteLine("-------------------------------------");
            
            //Las tuplas son mutables por lo que se puede cambiar su contenido 
            myTupleSmall.Item1 = "Elemento Actualizado";
            myTupleSmall.Item2 = 0;

            Console.WriteLine("Contenido Actualizado de tupla corta: {0} : {1}", myTupleSmall.Item1, myTupleSmall.Item2);
            Console.WriteLine("-------------------------------------");

            //Definiendo explicitamente los tipos
            (int, double) mythirdTuple = (5, 6.7);
            Console.WriteLine("Mi tercer tupla: {0}", mythirdTuple);
            Console.WriteLine("-------------------------------------");

            //Los metodos pueden regresar tuplas
            var myFourTuple = MethodReturnTuples();
            Console.WriteLine("Fuera del método:  \nNombre = {0}\nCalificación = {1} ", myFourTuple.Item2, myFourTuple.Item1); 
            Console.WriteLine("-------------------------------------");

            // Los elementos de una tupla pueden ser nombrados
            var auto = (modelo: "TX458", precio: 166025);
            Console.WriteLine("Automovil:  \nModelo = {0}\nPrecio = {1} ", auto.modelo, auto.precio); 

         }

         public (int, string) MethodReturnTuples(){
             string name = "Ana";
             int score = 10;

             Console.WriteLine("En el método:  \nNombre: {0}\nCalificación = {1} ", name, score); 

             return (score,name);
         }
    }
}