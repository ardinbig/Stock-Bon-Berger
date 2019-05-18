using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockBonBerger_Data.Models
{
    public class Approvisionnement : Base
    {
        public DateTime DateApprovisionnement { get; set; }

        public string CodeFournisseur { get; set; }

        public string Agent { get; set; }
    }
}
