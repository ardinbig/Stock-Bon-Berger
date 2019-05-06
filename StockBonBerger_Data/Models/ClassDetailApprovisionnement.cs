using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockBonBerger_Data.Models
{
    class DetailApprovisionnement
    {
        public string CodeApprov { get; set; }

        public string CodePiece { get; set; }

        public int Quantite { get; set; }

        public double Prix { get; set; }
    }
}
