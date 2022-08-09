using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Loop1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();

            //OBS: Opgaven er lavet i samarbejde med Jens

            //Dette for-loop starter rammen på position (x9,y4). 
            //Herefter sættes A efter A (horisontalt) i hendhold til for-loopets increment ("x+1").
            //Denne increment går hele vejen vejen op til 70'ende position pga "x < 69" delen af for-loopet.
            //Hvis lyden er slået til, vil "Colsole.Beep" supplere med et dejligt lydspor.

            for (int x = 9; x < 69; x = x +1)

            {
                Console.ForegroundColor
                = ConsoleColor.Red;

                Console.SetCursorPosition(x, 4);
                Console.Write("A");
                Console.Beep(700, 100);


            }

            //samme procedure gør sig gældende her, bortset fra at der i dette tilfælde bliver incrementet på y-aksen. 
            //derfor bliver "B"'erne i dette tilfælde skrevet vertikalt og ikke horisontalt, som tidligere. 

            for (int y = 4; y < 19; y = y + 1)

            {
                Console.ForegroundColor
                = ConsoleColor.White;

                Console.SetCursorPosition(69, y);
                Console.Write("B");
                Console.Beep(200, 50);
            }

            //samme procedure som ved første for-loop. Her bliver der dog incrementet med -1, da der skal udskrives i modsat rætning horisontalt.
            for (int x2 = 69; x2 > 9; x2 = x2 + -1)

            {
                Console.ForegroundColor
                = ConsoleColor.Black;

                Console.SetCursorPosition(x2,19);
                Console.Write("C");
                Console.Beep(100, 700);

            }

            //samme procedure som ved første for-loop. Her bliver der dog incrementet med -1, da der skal udskrives i modsat rætning vertikalt.
            for (int y2 = 19; y2 > 4; y2 = y2 + -1)

            {
                Console.ForegroundColor
                = ConsoleColor.Magenta;

                Console.SetCursorPosition(9, y2);
                Console.Write("D");
                Console.Beep(50, 200);
            }

            Thread.Sleep(200);
        }
    }
}
