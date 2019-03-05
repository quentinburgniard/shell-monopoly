using System;
using System.Collections.Generic;

namespace monopoly
{
    public class Joueur
    {
        List<Case> cases;
        string nom;
        Pion pion;
        int position = 0;
        Boolean prisonnier = false;
        Boolean rejouer;
        double solde = 2000;


        public Joueur()
        {
            cases = new List<Case>();
            Console.WriteLine("Saisir son nom");
            nom = Console.ReadLine().Trim();
            pion = new Pion();
        }

        public void Action(Des des) {
            rejouer = false;

            if (prisonnier == true)
            {
                ActionPrisonnier();
            }
            else
            {
                des.Lancer();

                if (des.Identique)
                {
                    rejouer = true;
                }
            }
        }

        public void ActionOrdinaire()
        {
            List<string> actions = new List<string>() { "Passer la main" };

            Console.WriteLine("Sélectionner une action");

            if (cases.Count > 0)
            {
                actions.Add("Lister mes propriétés");
                actions.Add("Hypothéquer une propriété");
            }

            MainClass.Selection(actions);
        }

        public void ActionPrisonnier()
        {
            List<string> actions = new List<string>();

            Console.WriteLine("Sélectionner une action");

            MainClass.Selection(actions);
        }

        public string Affichage()
        {
            return pion.Motif + " " + nom + " - $" + solde.ToString();
        }

        public List<Case> Cases
        {
            get
            {
                return cases;
            }
            set
            {
                cases = value;
            }
        }

        public string Nom
        {
            get
            {
                return nom;
            }
        }

        public Pion Pion
        {
            get
            {
                return pion;
            }
        }

        public int Position
        {
            get
            {
                return position;
            }

            set
            {
                if (value == 40)
                {
                    position = 0;
                    solde = solde + 200;
                }
                else
                {
                    position = value;
                }
            }
        }

        public Boolean Prisonnier
        {
            get
            {
                return prisonnier;
            }

            set
            {
                prisonnier = value;
            }
        }

        public Boolean Rejouer
        {
            get
            {
                return rejouer;
            }
        }

        public double Solde
        {
            get
            {
                return solde;
            }
            set
            {
                solde = value;
            }
        }
    }
}
