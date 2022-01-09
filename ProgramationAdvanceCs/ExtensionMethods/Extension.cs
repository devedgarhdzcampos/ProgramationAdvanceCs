namespace ExtensionsMethods
{
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
    }
}