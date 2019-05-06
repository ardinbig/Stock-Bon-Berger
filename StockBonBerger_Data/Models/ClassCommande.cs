using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockBonBerger_Data.Models
{
    class Commande : Base
    {
        public DateTime DateCommande { get; set; }

        public string CodeClient { get; set; }

        public string Agent { get; set; }

        public string Etat { get; set; }
    }
}
