namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class MateEquipPacks
    {
        public long? NpcId { get; set; }
        public long? ItemId { get; set; }

        public virtual ItemTemplate Item { get; set; }
        public virtual Npcs Npc { get; set; }
    }
}
