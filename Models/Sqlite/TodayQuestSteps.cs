namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class TodayQuestSteps
    {
        public long Id { get; set; }
        public string Description { get; set; }
        public long? ExpeditionLevelMax { get; set; }
        public long? ExpeditionLevelMin { get; set; }
        public byte[] ExpeditionOnly { get; set; }
        public long? FamilyLevelMax { get; set; }
        public long? FamilyLevelMin { get; set; }
        public byte[] FamilyOnly { get; set; }
        public long? IconId { get; set; }
        public long? ItemNum { get; set; }
        public long? ItemId { get; set; }
        public string Name { get; set; }
        public byte[] OrUnitReqs { get; set; }
        public long? RealStep { get; set; }

        public virtual Icons Icon { get; set; }
        public virtual ItemTemplate Item { get; set; }
    }
}
