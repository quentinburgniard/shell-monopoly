using System;
using System.Collections.Generic;

namespace monopoly
{
    public class Joueurs : List<Joueur>
    {
        public Joueurs()
        {
            List<Joueur> joueurs = new List<Joueur>();
            Random random = new Random();

            Console.WriteLine("Joueur 1");
            joueurs.Add(new Joueur());

            Console.WriteLine("Joueur 2");
            joueurs.Add(new Joueur());

            while (joueurs.Count > 0)
            {
                int i = random.Next(0, joueurs.Count);
                Add(joueurs[i]);
                joueurs.RemoveAt(i);
            }
        }
    }
}
