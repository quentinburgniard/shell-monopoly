using System;
namespace monopoly
{
    public class Prison : Case
    {
        public Prison(string nom) : base(nom)
        {
            
        }

        public override void Action(Joueur joueur)
        {
            joueur.Position = 11;
            joueur.Prisonnier = true;
        }
    }
}