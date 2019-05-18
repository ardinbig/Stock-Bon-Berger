using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockBonBerger_Data.Models
{
    public class Fournisseur : Base
    {
        public string Noms { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Adresse { get; set; }
    }
}
