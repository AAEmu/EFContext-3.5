namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class DoodadFuncDominionTaxInKinds
    {
        public long Id { get; set; }
        public long? Count { get; set; }
        public long? ItemId { get; set; }
        public long? NextPhase { get; set; }
        public string TooltipText { get; set; }

        public virtual ItemTemplate Item { get; set; }
    }
}
