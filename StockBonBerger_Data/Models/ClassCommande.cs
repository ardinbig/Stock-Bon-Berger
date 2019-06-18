using System;

namespace StockBonBerger_Data.Models
{
    public class Commande : Base
    {
        public DateTime DateCommande { get; set; }

        public string CodeClient { get; set; }

        public string Agent { get; set; }

        public string Etat { get; set; }
    }
}
