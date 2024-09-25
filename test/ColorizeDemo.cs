using kaleidolib.lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaleidolib.test
{
    internal class ColorizeDemo
    {
        static void Main()
        {
            Console.WriteLine(TextColor.red + "Hello" + TextColor.reset);
            Console.WriteLine(TextColor.black + "Hello" + TextColor.reset);
            Console.WriteLine(TextColor.green + "Hello" + TextColor.reset);
            Console.WriteLine(TextColor.yellow + "Hello" + TextColor.reset);
            Console.WriteLine(TextColor.blue + "Hello" + TextColor.reset);
            Console.WriteLine(TextColor.purple + "Hello" + TextColor.reset);
            Console.WriteLine(TextColor.cyan + "Hello" + TextColor.reset);
            Console.WriteLine(TextColor.white + "Hello" + TextColor.reset);
        }
    }
}
