using System;
using System.Collections.Generic;

namespace monopoly
{
    public class Case
    {
        protected string nom;

        public Case(string nom)
        {
            this.nom = nom;
        }

        public virtual void Action(Joueur joueur)
        {
            
        }

        public virtual string Affichage()
        {
            return nom;
        }

        public string Nom
        {
            get
            {
                return nom;
            }
        }
    }
}
