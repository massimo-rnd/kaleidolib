namespace kaleidolib.lib
{
    public class Formatting
    {
        private static string reset = TextStyle.reset;

        public static string bold(string formatString)
        {
            return TextStyle.bold + formatString + reset;
        }

        public static string italic(string formatString)
        {
            return TextStyle.italic + formatString + reset;
        }

        public static string dim(string formatString)
        {
            return TextStyle.dim + formatString + reset;
        }

        public static string slowblink(string formatString)
        {
            return TextStyle.slowblink + formatString + reset;
        }

        public static string rapidblink(string formatString)
        {
            return TextStyle.rapidblink + formatString + reset;
        }

        public static string reverse(string formatString)
        {
            return TextStyle.reverse + formatString + reset;
        }

        public static string invisible(string formatString)
        {
            return TextStyle.invisible + formatString + reset;
        }
    }
}
