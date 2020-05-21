namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ItemSpawnDoodads
    {
        public long? ItemId { get; set; }
        public long? DoodadId { get; set; }

        public virtual ItemTemplate Item { get; set; }
    }
}
