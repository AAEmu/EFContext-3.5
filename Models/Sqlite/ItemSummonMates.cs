namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ItemSummonMates
    {
        public long? ItemId { get; set; }
        public long? NpcId { get; set; }

        public virtual ItemTemplate Item { get; set; }
        public virtual Npcs Npc { get; set; }
    }
}
