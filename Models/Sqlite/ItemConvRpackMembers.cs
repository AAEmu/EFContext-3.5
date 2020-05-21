namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ItemConvRpackMembers
    {
        public long Id { get; set; }
        public long? ItemConvRpackId { get; set; }
        public long? ItemConvId { get; set; }

        public virtual ItemConvs ItemConv { get; set; }
        public virtual ItemConvRpacks ItemConvRpack { get; set; }
    }
}
