using System;
using System.Collections.Generic;

namespace monopoly
{
    public class Pion
    {
        static readonly List<string> motifs = new List<string>() { "\ud83d\udc1f", "\ud83d\udc1d", "\ud83d\udc19", "\ud83d\udc1f" };

        string motif;

        public Pion()
        {
            Console.WriteLine("Sélectionner un pion");
            motif = motifs[MainClass.Selection(motifs)];
        }

        public string Motif
        {
            get
            {
                return motif;
            }
        }
    }
}
