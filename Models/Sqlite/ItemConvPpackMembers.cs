namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ItemConvPpackMembers
    {
        public long Id { get; set; }
        public long? ItemConvPpackId { get; set; }
        public long? ItemConvId { get; set; }

        public virtual ItemConvs ItemConv { get; set; }
        public virtual ItemConvPpacks ItemConvPpack { get; set; }
    }
}
