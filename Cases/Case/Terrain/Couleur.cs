using System;
namespace monopoly
{
    public class Couleur
    {
        int nbrPropriete;
        string nom;

        double prixMaison, prixHotel;

        public Couleur(string nom, double prixMaison, double prixHotel, int nbrPropriete)
        {
            this.nom = nom;
            this.prixMaison = prixMaison;
            this.prixHotel = prixHotel;
            this.nbrPropriete = nbrPropriete;
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
