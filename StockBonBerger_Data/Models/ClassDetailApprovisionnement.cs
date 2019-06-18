namespace StockBonBerger_Data.Models
{
    public class DetailApprovisionnement : Base
    {
        public int CodeApprov { get; set; }

        public int CodePiece { get; set; }

        public int Quantite { get; set; }

        public double Prix { get; set; }
    }
}
