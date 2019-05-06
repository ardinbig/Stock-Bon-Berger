using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockBonBerger_Data.Models
{
    class Paiement : Base
    {
        public double MontantPaye { get; set; }

        public string CodeModePaiement { get; set; }

        public string Agent { get; set; }
    }
}
