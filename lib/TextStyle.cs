using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaleidolib.lib
{
    public class TextStyle
    {
        // Text Styles
        public static string reset = "\x1B[0m";
        public static string bold = "\x1B[1m";
        public static string italic = "\x1B[3m";
        public static string dim = "\x1B[2m";
        public static string slowblink = "\x1B[5m"; // might not be supported in your terminal
        public static string rapidblink = "\x1B[6m"; // rarely supported
        public static string reverse = "\x1B[7m";
        public static string invisible = "\x1B[8m"; // still able to be copied

         // Text Decorations
        public static string underline = "\x1B[4m";
        public static string thickunderline = "\x1B[21m";
        public static string italicunderline = "\x1B[4:3m";
        public static string strikethrough = "\x1B[9m";
        public static string overline = "\x1B[53m";
    }
}
