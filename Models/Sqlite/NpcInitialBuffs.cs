namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class NpcInitialBuffs
    {
        public long? NpcId { get; set; }
        public long? BuffId { get; set; }

        public virtual Buffs Buff { get; set; }
        public virtual Npcs Npc { get; set; }
    }
}
