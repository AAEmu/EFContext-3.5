namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class CraftPackCrafts
    {
        public long Id { get; set; }
        public long? CraftPackId { get; set; }
        public long? CraftId { get; set; }

        public virtual Crafts Craft { get; set; }
        public virtual CraftPacks CraftPack { get; set; }
    }
}
