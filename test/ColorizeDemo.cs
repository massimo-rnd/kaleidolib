﻿using kaleidolib.lib;

namespace kaleidolib.test
{
    internal class ColorizeDemo
    {
        static void Main()
        {
            Console.WriteLine("Welcome to " + Color.blue("K") + Color.cyan("A") + Color.red("L") + Color.green("E") + Color.purple("I") + Color.white("D") + Color.yellow("O") + "LIB");
            color();
            background();
            formatting();
            lining();
            combined();
        }

        static void color()
        {
            Console.WriteLine("You can have colors!\n");
            Console.WriteLine(Color.black("Hello!"));
            Console.WriteLine(Color.red("Hallo!"));
            Console.WriteLine(Color.green("Bonjour!"));
            Console.WriteLine(Color.yellow("Hola!"));
            Console.WriteLine(Color.blue("Ciao!"));
            Console.WriteLine(Color.purple("Olà!"));
            Console.WriteLine(Color.cyan("Namaste!"));
            Console.WriteLine(Color.white("Salaam!"));
            Console.WriteLine("\n-------------------------\n");
            Console.WriteLine("And even more colors!\n");
            Console.WriteLine(Color.lightBlack("Hello!"));
            Console.WriteLine(Color.lightRed("Hallo!"));
            Console.WriteLine(Color.lightGreen("Bonjour!"));
            Console.WriteLine(Color.lightYellow("Hola!"));
            Console.WriteLine(Color.lightBlue("Ciao!"));
            Console.WriteLine(Color.lightMagenta("Olà!"));
            Console.WriteLine(Color.lightCyan("Namaste!"));
            Console.WriteLine(Color.lightWhite("Salaam!"));
            Console.WriteLine("\n-------------------------\n");
        }

        static void background()
        {
            Console.WriteLine("You can have backgrounds!\n");
            Console.WriteLine(Background.black("Merhaba!"));
            Console.WriteLine(Background.red("Sain bainuu!"));
            Console.WriteLine(Background.green("Nay Hoh!"));
            Console.WriteLine(Background.yellow("Szia!"));
            Console.WriteLine(Background.blue("Marhaba!"));
            Console.WriteLine(Background.purple("Sannu!"));
            Console.WriteLine(Background.cyan("Jambo!"));
            Console.WriteLine(Background.white("Ni Hau!"));
            Console.WriteLine("\n-------------------------\n");
            Console.WriteLine("And even more backgrounds!\n");
            Console.WriteLine(Background.lightBlack("Merhaba!"));
            Console.WriteLine(Background.lightRed("Sain bainuu!"));
            Console.WriteLine(Background.lightGreen("Nay Hoh!"));
            Console.WriteLine(Background.lightYellow("Szia!"));
            Console.WriteLine(Background.lightBlue("Marhaba!"));
            Console.WriteLine(Background.lightMagenta("Sannu!"));
            Console.WriteLine(Background.lightCyan("Jambo!"));
            Console.WriteLine(Background.lightWhite("Ni Hau!"));
            Console.WriteLine("\n-------------------------\n");
        }

        static void formatting()
        {
            Console.WriteLine("You can have formattings!\n");
            Console.WriteLine(Formatting.bold("Halo!"));
            Console.WriteLine(Formatting.italic("Oi!"));
            Console.WriteLine(Formatting.dim("Zdravstvujte!"));
            Console.WriteLine(Formatting.slowblink("Sà-wàt-dee!"));
            Console.WriteLine(Formatting.rapidblink("Sà-wàt-dee!"));
            Console.WriteLine(Formatting.reverse("Cześć!"));
            Console.WriteLine(Formatting.invisible("Akkam!"));
            Console.WriteLine("\n-------------------------\n");
        }

        static void lining()
        {
            Console.WriteLine("You can have \"linings\"!\n");
            Console.WriteLine(Lining.underline("Silaw!"));
            Console.WriteLine(Lining.thickunderline("Salut!"));
            Console.WriteLine(Lining.italicunderline("Musta!"));
            Console.WriteLine(Lining.strikethrough("Salam!"));
            Console.WriteLine(Lining.overline("Pranam!"));
            Console.WriteLine(Lining.framed("Pranam!"));
            Console.WriteLine("\n-------------------------\n");
        }

        static void combined()
        {
            Console.WriteLine("You can also combine them!\n");
            Console.WriteLine(Background.green(Lining.underline(Color.blue("Ndêwó!"))));
            Console.WriteLine(Color.yellow(Background.white("Mbote!")));
            Console.WriteLine(Lining.strikethrough(Color.purple("Yassou!")));
            Console.WriteLine(Lining.strikethrough(Lining.underline("God dag!")));
        }
    }
}
