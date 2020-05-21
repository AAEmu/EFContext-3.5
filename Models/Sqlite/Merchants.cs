namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class Merchants
    {
        public long? NpcId { get; set; }
        public long? ItemId { get; set; }
        public long? GradeId { get; set; }
        public long? KindId { get; set; }

        public virtual ItemTemplate Item { get; set; }
        public virtual Npcs Npc { get; set; }
    }
}
