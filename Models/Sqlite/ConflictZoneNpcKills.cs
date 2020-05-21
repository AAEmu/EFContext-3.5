namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ConflictZoneNpcKills
    {
        public long Id { get; set; }
        public long? ConflictZoneId { get; set; }
        public long? NpcId { get; set; }

        public virtual Npcs Npc { get; set; }
    }
}
