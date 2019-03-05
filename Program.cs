using System;
using System.Collections.Generic;

namespace monopoly
{
    class MainClass
    {
        public static void Main()
        {
            Jeu jeu = new Jeu();
        }

        public static int Selection(List<string> args)
        {
            int selection = 0;

            for (int i = 0; i < args.Count; i++)
            {
                Console.WriteLine(" " + (i + 1) + ". " + args[i]);
            }

            try
            {
                int saisie = int.Parse(Console.ReadLine());

                if (0 < (saisie - 1) && (saisie - 1) < args.Count)
                {
                    selection = (saisie - 1);
                }
            }
            catch
            {

            }

            return selection;
        }
    }
}
