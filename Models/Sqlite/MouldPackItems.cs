namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class MouldPackItems
    {
        public long Id { get; set; }
        public long? MouldPackId { get; set; }
        public long? MouldId { get; set; }

        public virtual Moulds Mould { get; set; }
        public virtual MouldPacks MouldPack { get; set; }
    }
}
