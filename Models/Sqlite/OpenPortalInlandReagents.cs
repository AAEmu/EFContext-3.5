namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class OpenPortalInlandReagents
    {
        public long Id { get; set; }
        public long? Amount { get; set; }
        public long? ItemId { get; set; }
        public long? OpenPortalEffectId { get; set; }
        public long? Priority { get; set; }

        public virtual ItemTemplate Item { get; set; }
        public virtual OpenPortalEffects OpenPortalEffect { get; set; }
    }
}
