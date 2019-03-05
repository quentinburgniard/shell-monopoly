using System;
namespace monopoly
{
    public class Impot : Case
    {
        double impot;

        public Impot(string nom, double impot) : base(nom)
        {
            this.impot = impot;
        }

        public override void Action(Joueur joueur)
        {
            joueur.Solde = joueur.Solde - impot;
        }
    }
}