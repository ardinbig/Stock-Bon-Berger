namespace StockBonBerger_Data.Models
{
    public class DetailCommande : Base
    {
        public string CodeCommande { get; set; }

        public string CodePiece { get; set; }

        public int Quantite { get; set; }

        public double Prix { get; set; }
    }
}
