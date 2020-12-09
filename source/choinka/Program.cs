using System;
using System.Threading;

namespace choinka
{
    class Program
    {
        public static void RewriteLine(int lineNumber, String newText)
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, currentLineCursor - lineNumber);
            Console.Write(newText); Console.WriteLine(new string(' ', Console.WindowWidth - newText.Length));
            Console.SetCursorPosition(0, currentLineCursor);
        }

        static void Main()
        {
            WMPLib.WindowsMediaPlayer kolenda = new WMPLib.WindowsMediaPlayer();
            kolenda.URL = "choinka.mp3";
            kolenda.controls.play();
            Console.Title = "Merry Christmas <3";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"                         /\");
            Thread.Sleep(1000);
            Console.WriteLine(@"                        <  >");
            Thread.Sleep(1000);
            Console.WriteLine(@"                         \/");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"                         /\");
            Thread.Sleep(1000);
            Console.WriteLine(@"                        /  \");
            Thread.Sleep(1000);
            Console.WriteLine(@"                       /++++\");
            Thread.Sleep(1000);
            Console.WriteLine(@"                      /  ()  \");
            Thread.Sleep(1000);
            Console.WriteLine(@"                      /      \");
            Thread.Sleep(1000);
            Console.WriteLine(@"                     /~`~`~`~`\");
            Thread.Sleep(1000);
            Console.WriteLine(@"                    /  ()  ()  \");
            Thread.Sleep(1000);
            Console.WriteLine(@"                    /          \");
            Thread.Sleep(1000);
            Console.WriteLine(@"                   /*&*&*&*&*&*&\");
            Thread.Sleep(1000);
            Console.WriteLine(@"                  /  ()  ()  ()  \");
            Thread.Sleep(1000);
            Console.WriteLine(@"                  /              \");
            Thread.Sleep(1000);
            Console.WriteLine(@"                 /++++++++++++++++\");
            Thread.Sleep(1000);
            Console.WriteLine(@"                /  ()  ()  ()  ()  \");
            Thread.Sleep(1000);
            Console.WriteLine(@"                /                  \");
            Thread.Sleep(1000);
            Console.WriteLine(@"               /~`~`~`~`~`~`~`~`~`~`\");
            Thread.Sleep(1000);
            Console.WriteLine(@"              /  ()  ()  ()  ()  ()  \");
            Thread.Sleep(1000);
            Console.WriteLine(@"              /*&*&*&*&*&*&*&*&*&*&*&\");
            Thread.Sleep(1000);
            Console.WriteLine(@"             /                        \");
            Thread.Sleep(1000);
            Console.WriteLine(@"            /,.,.,.,.,.,.,.,.,.,.,.,.,.\");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(@"                       |   |");
            Thread.Sleep(1000);
            Console.WriteLine(@"                      |`````|");
            Thread.Sleep(1000);
            Console.WriteLine(@"                      \_____/");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(@"             ──────╔╦╗╔╗╔╗╔╗╗╔───────");
            Thread.Sleep(500);
            Console.WriteLine(@"             ──────║║║╠─║─║─╚╣───────");
            Thread.Sleep(500);
            Console.WriteLine(@"             ──────╝─╚╚╝╩─╩─╚╝───────");
            Thread.Sleep(500);
            Console.WriteLine(@"             ╔═╗╗─╔╔╗─╦╔═╗╔╦╗╔╦╗╔╗╔═╗");
            Thread.Sleep(500);
            Console.WriteLine(@"             ║──╠═╣╠╩╗║╚═╗─║─║║║╠╣╚═╗");
            Thread.Sleep(500);
            Console.WriteLine(@"             ╚═╝╝─╚╝─╩╩╚═╝─╩─╝╩╚╩╩╚═╝");
            Thread.Sleep(500);
            Console.ForegroundColor = ConsoleColor.Green;
            while (true)
            {
                Thread.Sleep(400);
                Console.ForegroundColor = ConsoleColor.Green;
                RewriteLine(6, @"             ──────╔╦╗╔╗╔╗╔╗╗╔───────");
                RewriteLine(5, @"             ──────║║║╠─║─║─╚╣───────");
                RewriteLine(4, @"             ──────╝─╚╚╝╩─╩─╚╝───────");
                RewriteLine(3, @"             ╔═╗╗─╔╔╗─╦╔═╗╔╦╗╔╦╗╔╗╔═╗");
                RewriteLine(2, @"             ║──╠═╣╠╩╗║╚═╗─║─║║║╠╣╚═╗");
                RewriteLine(1, @"             ╚═╝╝─╚╝─╩╩╚═╝─╩─╝╩╚╩╩╚═╝");
                Console.ForegroundColor = ConsoleColor.Red;
                Thread.Sleep(400);
                RewriteLine(6, @"             ──────╔╦╗╔╗╔╗╔╗╗╔───────");
                RewriteLine(5, @"             ──────║║║╠─║─║─╚╣───────");
                RewriteLine(4, @"             ──────╝─╚╚╝╩─╩─╚╝───────");
                RewriteLine(3, @"             ╔═╗╗─╔╔╗─╦╔═╗╔╦╗╔╦╗╔╗╔═╗");
                RewriteLine(2, @"             ║──╠═╣╠╩╗║╚═╗─║─║║║╠╣╚═╗");
                RewriteLine(1, @"             ╚═╝╝─╚╝─╩╩╚═╝─╩─╝╩╚╩╩╚═╝");
                Console.ForegroundColor = ConsoleColor.Green;
                Thread.Sleep(1200);
                RewriteLine(30, @"                         /\");
                RewriteLine(29, @"                        /  \");
                RewriteLine(28, @"                       /++++\");
                RewriteLine(26, @"                      /      \");
                RewriteLine(23, @"                    /          \");
                RewriteLine(20, @"                  /              \");
                RewriteLine(19, @"                 /++++++++++++++++\");
                RewriteLine(17, @"                /                  \");
                RewriteLine(13, @"             /                        \");
                RewriteLine(22, @"                   /&*&*&*&*&*&*\");
                RewriteLine(27, @"                      / *()* \");
                RewriteLine(25, @"                     /`~`~`~`~\");
                RewriteLine(24, @"                    /  ()  ()  \");
                RewriteLine(21, @"                  / *()**()**()* \");
                RewriteLine(18, @"                / *()**()**()**()* \");
                RewriteLine(16, @"               /`~`~`~`~`~`~`~`~`~`~\");
                RewriteLine(15, @"              / *()**()**()**()**()* \");
                RewriteLine(14, @"              /&*&*&*&*&*&*&*&*&*&*&*\");
                RewriteLine(12, @"            /.,.,.,.,.,.,.,.,.,.,.,.,.,\");
                Console.ForegroundColor = ConsoleColor.Red;
                Thread.Sleep(400);
                Console.ForegroundColor = ConsoleColor.Green;
                RewriteLine(6, @"             ──────╔╦╗╔╗╔╗╔╗╗╔───────");
                RewriteLine(5, @"             ──────║║║╠─║─║─╚╣───────");
                RewriteLine(4, @"             ──────╝─╚╚╝╩─╩─╚╝───────");
                RewriteLine(3, @"             ╔═╗╗─╔╔╗─╦╔═╗╔╦╗╔╦╗╔╗╔═╗");
                RewriteLine(2, @"             ║──╠═╣╠╩╗║╚═╗─║─║║║╠╣╚═╗");
                RewriteLine(1, @"             ╚═╝╝─╚╝─╩╩╚═╝─╩─╝╩╚╩╩╚═╝");
                Console.ForegroundColor = ConsoleColor.Red;
                Thread.Sleep(400);
                RewriteLine(6, @"             ──────╔╦╗╔╗╔╗╔╗╗╔───────");
                RewriteLine(5, @"             ──────║║║╠─║─║─╚╣───────");
                RewriteLine(4, @"             ──────╝─╚╚╝╩─╩─╚╝───────");
                RewriteLine(3, @"             ╔═╗╗─╔╔╗─╦╔═╗╔╦╗╔╦╗╔╗╔═╗");
                RewriteLine(2, @"             ║──╠═╣╠╩╗║╚═╗─║─║║║╠╣╚═╗");
                RewriteLine(1, @"             ╚═╝╝─╚╝─╩╩╚═╝─╩─╝╩╚╩╩╚═╝");
                Thread.Sleep(1200);
                RewriteLine(30, @"                         /\");
                RewriteLine(29, @"                        /  \");
                RewriteLine(28, @"                       /++++\");
                RewriteLine(26, @"                      /      \");
                RewriteLine(23, @"                    /          \");
                RewriteLine(20, @"                  /              \");
                RewriteLine(19, @"                 /++++++++++++++++\");
                RewriteLine(17, @"                /                  \");
                RewriteLine(13, @"             /                        \");
                RewriteLine(22, @"                   /*&*&*&*&*&*&\");
                RewriteLine(27, @"                      /  ()  \");
                RewriteLine(25, @"                     /~`~`~`~`\");
                RewriteLine(24, @"                    /  ()  ()  \");
                RewriteLine(21, @"                  /  ()  ()  ()  \");
                RewriteLine(18, @"                /  ()  ()  ()  ()  \");
                RewriteLine(16, @"               /~`~`~`~`~`~`~`~`~`~`\");
                RewriteLine(15, @"              /  ()  ()  ()  ()  ()  \");
                RewriteLine(14, @"              /*&*&*&*&*&*&*&*&*&*&*&\");
                RewriteLine(12, @"            /,.,.,.,.,.,.,.,.,.,.,.,.,.\");
                Console.ForegroundColor = ConsoleColor.Green;
            }

        }
    }
}
