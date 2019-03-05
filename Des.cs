using System;

namespace monopoly
{
    public class Des
    {
        static readonly string motif = "Dé";

        Boolean identique;
        int nbrLancer = 0;
        Random random = new Random();
        int[] valeurs = new int[2];

        public Des()
        {
            
        }

        public int[] Lancer(){
            identique = false;

            for (int i = 0; i < 2; i++)
            {
                valeurs[i] = random.Next(1, 6);
            }

            if (valeurs[0] == valeurs[1])
            {
                identique = true;
            }

            nbrLancer++;

            return valeurs;
        }

        public string Affichage()
        {
            return motif + " : " + valeurs[0] + " | " + valeurs[1];
        }

        public Boolean Identique
        {
            get
            {
                return identique;
            }
        }

        public int[] Valeurs
        {
            get
            {
                return valeurs;
            }
        }
    }
}
