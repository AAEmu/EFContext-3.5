namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class DoodadFuncCraftPacks
    {
        public long Id { get; set; }
        public long? CraftPackId { get; set; }

        public virtual CraftPacks CraftPack { get; set; }
    }
}
