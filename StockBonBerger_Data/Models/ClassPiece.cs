using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockBonBerger_Data.Models
{
    public class Piece : Base
    {
        public string Designation { get; set; }

        public string CodeCategoriePiece { get; set; }

        public string LieuFabrication { get; set; }

        public string NumeroSerie { get; set; }

        public string Usage { get; set; }
    }
}
