using System;
using System.Linq;
using System.Threading;

namespace monopoly
{
    public class Jeu
    {
        Des des = new Des();
        Cases cases = new Cases();
        Joueurs joueurs = new Joueurs();
        Plateau plateau = new Plateau();

        public Jeu()
        {
            plateau.Initialisation();
            plateau.Affichage();

            while (joueurs.Count > 1)
            {
                foreach (Joueur joueur in joueurs)
                {
                    do
                    {
                        plateau.Initialisation();
                        plateau.Affichage();
                        joueur.Action(des);
                        plateau.Des(des);

                        for (int i = 0; i < des.Valeurs.Sum(); i++)
                        {
                            joueur.Position++;
                            plateau.Initialisation();
                            plateau.Joueurs(joueurs);
                            plateau.Pions(joueurs);
                            plateau.Affichage();
                            Thread.Sleep(500);
                        }

                        plateau.Case(cases[joueur.Position]);
                        plateau.Affichage();

                        cases[joueur.Position].Action(joueur);
                    } while (joueur.Rejouer);

                    plateau.Joueurs(joueurs);
                    plateau.Affichage();

                    joueur.ActionOrdinaire();
                }
            }
        }
    }
}
