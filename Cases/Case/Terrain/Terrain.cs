using System;
using System.Collections.Generic;

namespace monopoly
{
    public class Terrain : Case
    {
        Couleur couleur;
        double baseLoyer, loyer, prix;
        int hotel = 0, maison = 0;
        static int[] indiceLoyer = { 1, 5, 15, 30, 45, 54 };
        Joueur proprietaire = null;

        public Terrain(string nom, double prix, double baseLoyer, Couleur couleur) : base(nom)
        {
            this.prix = prix;
            this.baseLoyer = baseLoyer;
            this.loyer = baseLoyer;
            this.couleur = couleur;
        }

        public override void Action(Joueur joueur)
        {
            List<string> actions = new List<string>() { "Continuer" };

            Console.WriteLine("Sélectionner une action");

            if (proprietaire == null)
            {
                actions.Add("Acheter la propriété");

                if (MainClass.Selection(actions) == 1)
                {
                    Achat(joueur);
                }
            }
            else
            {
                if (joueur != proprietaire)
                {
                    PaiementLoyer(joueur);
                }
            }
        }

        public void Achat(Joueur joueur)
        {
            if (joueur.Solde > prix)
            {
                joueur.Solde = joueur.Solde - prix;
                proprietaire = joueur;
                joueur.Cases.Add(this);
            }
            else {
                Console.WriteLine("Solde insufisant");
            }
        }

        public void PaiementLoyer(Joueur joueur)
        {
            joueur.Solde = joueur.Solde - loyer;
            proprietaire.Solde = proprietaire.Solde + loyer;
        }

        public double Loyer
        {
            get
            {
                return loyer;
            }

            set
            {
                if (hotel == 1)
                {
                    loyer = baseLoyer * indiceLoyer[5];
                }
                else
                {
                    loyer = baseLoyer * indiceLoyer[maison];
                }
            }
        }

        public override string Affichage()
        {
            if (proprietaire == null)
            {
                return nom + " - " + couleur.Nom + " - Prix : $" + prix;
            }
            else
            {
                return nom + " - " + couleur.Nom + " - Loyer : $" + loyer;
            }
        }
    }
}
