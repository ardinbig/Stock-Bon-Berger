using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockBonBerger_Data.Models
{
    class Vente : Base
    {
        public DateTime DateVente { get; set; }

        public string CodeClient { get; set; }

        public string Agent { get; set; }
    }
}
