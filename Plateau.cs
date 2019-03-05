using System;
namespace monopoly
{
    public class Plateau
    {
        string[] cases = new string[40];
        string[] instructions = new string[8];

        public Plateau()
        {
            
        }

        public void Affichage()
        {
            Console.Clear();
            Console.WriteLine("╔═══════════════════════════════╗");

            Console.Write("║ ");
            for (int i = Convert.ToInt32(cases.Length * 0.5); i < Convert.ToInt32(cases.Length * 0.75); i++)
            {
                Console.Write(cases[i] + " ");
            }
            Console.WriteLine("║");

            Console.Write("║");
            Console.Write(" " + cases[Convert.ToInt32(cases.Length * 0.5 - 1)] + " ");
            Console.Write("╔═════════════════════╗");
            Console.Write(" " + cases[Convert.ToInt32(cases.Length * 0.75)] + " ");
            Console.WriteLine("║");

            int x = Convert.ToInt32(cases.Length * 0.5 - 2);
            int y = Convert.ToInt32(cases.Length * 0.75 + 1);

            for (int i = 0; i < Convert.ToInt32(cases.Length * 0.25 - 2); i++)
            {
                Console.Write("║");
                Console.Write(" " + cases[x] + " ");
                Console.Write("║                     ║");
                Console.Write(" " + cases[y] + " ");
                Console.WriteLine("║    " + instructions[i]);
                x--;
                y++;
            }

            Console.Write("║");
            Console.Write(" " + cases[Convert.ToInt32(cases.Length * 0.25)] + " ");
            Console.Write("╚═════════════════════╝");
            Console.Write(" " + cases[Convert.ToInt32(cases.Length * 1 - 1)] + " ");
            Console.WriteLine("║");

            Console.Write("║ ");
            for (int i = Convert.ToInt32(cases.Length * 0.25 - 1); i > Convert.ToInt32(cases.Length * 0 - 1); i--)
            {
                Console.Write(cases[i] + " ");
            }
            Console.WriteLine("║");

            Console.WriteLine("╚═══════════════════════════════╝");
        }

        public void Initialisation()
        {
            for (int i = 0; i < cases.Length; i++)
            {
                cases[i] = "  ";
            }
        }

        public void Des(Des des)
        {
            instructions[3] = des.Affichage();
        }

        public void Joueurs(Joueurs joueurs)
        {
            instructions[0] = joueurs[0].Affichage();
            instructions[1] = joueurs[1].Affichage();
        }

        public void Pions(Joueurs joueurs)
        {
            foreach (Joueur joueur in joueurs)
            {
                cases[joueur.Position] = joueur.Pion.Motif;
            } 
        }

        public void Case(Case monopolyCase)
        {
            instructions[7] = monopolyCase.Affichage();
        }
    }
}
