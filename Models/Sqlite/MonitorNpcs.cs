namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class MonitorNpcs
    {
        public long? NpcId { get; set; }

        public virtual Npcs Npc { get; set; }
    }
}
