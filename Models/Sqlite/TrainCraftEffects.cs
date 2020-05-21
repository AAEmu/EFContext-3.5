namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class TrainCraftEffects
    {
        public long Id { get; set; }
        public long? CraftId { get; set; }

        public virtual Crafts Craft { get; set; }
    }
}
