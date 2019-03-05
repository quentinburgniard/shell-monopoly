using System;
namespace monopoly
{
    public class Depart : Case
    {
        double salaire;

        public Depart(string nom, double salaire) : base(nom)
        {
            this.salaire = salaire;
        }

        public override void Action(Joueur joueur)
        {
            joueur.Solde = joueur.Solde + salaire;
        }
    }
}
