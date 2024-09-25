using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaleidolib.lib
{
    public class Background
    {
        private static string reset = TextColor.reset;

        public static string black(string colorString)
        {
            return TextColor.black + colorString + reset;
        }

        public static string red(string colorString)
        {
            return TextColor.red + colorString + reset;
        }

        public static string green(string colorString)
        {
            return TextColor.green + colorString + reset;
        }

        public static string yellow(string colorString)
        {
            return TextColor.yellow + colorString + reset;
        }

        public static string blue(string colorString)
        {
            return TextColor.blue + colorString + reset;
        }

        public static string purple(string colorString)
        {
            return TextColor.purple + colorString + reset;
        }

        public static string cyan(string colorString)
        {
            return TextColor.cyan + colorString + reset;
        }

        public static string white(string colorString)
        {
            return TextColor.white + colorString + reset;
        }
    }
}
