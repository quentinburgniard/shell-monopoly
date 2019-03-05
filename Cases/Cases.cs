using System;
using System.Collections.Generic;

namespace monopoly
{
    public class Cases : List<Case>
    {
        Couleur marron, bleuCiel, rose, orange, rouge, jaune, vert, bleu;

        public Cases()
        {
            marron = new Couleur("Marron", 100, 100, 2);
            bleuCiel = new Couleur("Bleu ciel", 100, 100, 3);
            rose = new Couleur("Rose", 100, 100, 3);
            orange = new Couleur("Orange", 100, 100, 3);
            rouge = new Couleur("Rouge", 100, 100, 3);
            jaune = new Couleur("Jaune", 100, 100, 3);
            vert = new Couleur("Vert", 100, 100, 3);
            bleu = new Couleur("Bleu", 100, 100, 2);

            this.Add(new Depart("Départ", 2000));
            this.Add(new Terrain("Canal Rideau", 150, 150, marron));
            this.Add(new Communaute("Caisse de communauté"));
            this.Add(new Terrain("Coline du Parlement", 150, 150, marron));
            this.Add(new Impot("Impôt sur le revenu", 200));
            this.Add(new Aeroport("Aéroport de Montréal"));
            this.Add(new Terrain("Lac Louise", 150, 150, bleuCiel));
            this.Add(new Chance("Chance"));
            this.Add(new Terrain("Fleuve Mackenvie", 150, 150, bleuCiel));
            this.Add(new Terrain("Lac Athabasca", 150, 150, bleuCiel));
            this.Add(new Case("Visite en Prison"));
            this.Add(new Terrain("Rocher Percé", 150, 150, rose));
            this.Add(new Compagnie("Compagnie de distribution d'électricité"));
            this.Add(new Terrain("Miles Canyon", 150, 150, rose));
            this.Add(new Terrain("Champ de glace Columbia", 150, 150, rose));
            this.Add(new Aeroport("Aéroport de Toronto"));
            this.Add(new Terrain("Colline Signal", 150, 150, orange));
            this.Add(new Communaute("Caisse de communauté"));
            this.Add(new Terrain("Peggy's Cove", 150, 150, orange));
            this.Add(new Terrain("Tunnel de Moose Jaw", 150, 150, orange));
            this.Add(new Case("Parc gratuit"));
            this.Add(new Terrain("Pont de la Confédération", 150, 150, rouge));
            this.Add(new Chance("Chance"));
            this.Add(new Terrain("Île de Baffin", 150, 150, rouge));
            this.Add(new Terrain("Baie de Fundy", 150, 150, rouge));
            this.Add(new Aeroport("Aéroport d'Halifax"));
            this.Add(new Terrain("Parc provincial Algonouin", 150, 150, jaune));
            this.Add(new Terrain("Parc national Wapusk", 150, 150, jaune));
            this.Add(new Compagnie("Compagnie de distribution des eaux"));
            this.Add(new Terrain("Whistler", 150, 150, jaune));
            this.Add(new Prison("Prison"));
            this.Add(new Terrain("Rue Robson", 150, 150, vert));
            this.Add(new Terrain("Rue Sainte-Catherine", 150, 150, vert));
            this.Add(new Communaute("Caisse de communauté"));
            this.Add(new Terrain("Portage et Memorial", 150, 150, vert));
            this.Add(new Aeroport("Aéroport de Vancouver"));
            this.Add(new Chance("Chance"));
            this.Add(new Terrain("Chutes Niagara", 150, 150, bleu));
            this.Add(new Impot("Taxe de luxe", 100));
            this.Add(new Terrain("Fairmont Le Château Frontenac", 150, 150, bleu));
        }
    }
}
