namespace kaleidolib.lib
{
    public class Lining
    {
        private static string reset = TextStyle.reset;

        public static string underline(string liningString)
        {
            return TextStyle.underline + liningString + reset;
        }

        public static string thickunderline(string liningString)
        {
            return TextStyle.thickunderline + liningString + reset;
        }

        public static string italicunderline(string liningString)
        {
            return TextStyle.italicunderline + liningString + reset;
        }

        public static string strikethrough(string liningString)
        {
            return TextStyle.strikethrough + liningString + reset;
        }

        public static string overline(string liningString)
        {
            return TextStyle.overline + liningString + reset;
        }

        public static string framed(string liningString)
        {
            return TextStyle.framed + liningString + reset;
        }
    }
}
