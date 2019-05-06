using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockBonBerger_Data.Models
{
    class DetailCommande : Base
    {
        public string CodeCommande { get; set; }

        public string CodePiece { get; set; }

        public int Quantite { get; set; }

        public double Prix { get; set; }
    }
}
