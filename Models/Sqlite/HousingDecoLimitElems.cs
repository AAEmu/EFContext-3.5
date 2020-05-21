namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class HousingDecoLimitElems
    {
        public long Id { get; set; }
        public long? Count { get; set; }
        public long? DecoActabilityGroupId { get; set; }
        public long? HousingDecoLimitId { get; set; }

        public virtual DecoActabilityGroups DecoActabilityGroup { get; set; }
        public virtual HousingDecoLimits HousingDecoLimit { get; set; }
    }
}
