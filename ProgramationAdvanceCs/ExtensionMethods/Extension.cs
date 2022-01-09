namespace ExtensionsMethods
{
    using System.Collections;
    public static class ExtensionsMethods
    {
        public static string EnsureNotNull(this string? text)
        {
            if (text == null)
                text = string.Empty;
            
            return text;
        }

        public static int EnsureNotNull(this int? num)
        {
            if (num == null)
                num = 0;
            return Convert.ToInt32(num);
        }

        public static void PrintList(this Stack<int> num)
        {
            foreach (var item in num)
            {
                Console.WriteLine(item);
            }
        }

        public static void PrintList(this ArrayList arrayList)
        {
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
        }

        public static void PrintList(this BitArray bitArray, string name = "")
        {
            int c = 0;
            Console.Write("{0}\t", name);

            foreach (bool item in bitArray)
            {
                c++;
                if (item)
                    Console.Write("1");
                else   
                    Console.Write("0");
                if (c % 8 == 0)
                    Console.Write(", ");
            }
            Console.WriteLine();
        }
        public static void PrintStringText(this ArrayList arrayList)
        {
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.Write("{0} ", arrayList[i]);
            }
        }

    }
}