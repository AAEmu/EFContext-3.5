namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class DoodadFuncCraftStartCrafts
    {
        public long Id { get; set; }
        public long? CraftId { get; set; }
        public long? DoodadFuncCraftStartId { get; set; }

        public virtual Crafts Craft { get; set; }
        public virtual DoodadFuncCraftStarts DoodadFuncCraftStart { get; set; }
    }
}
