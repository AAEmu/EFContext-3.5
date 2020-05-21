namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class DoodadFuncAreaTriggers
    {
        public long Id { get; set; }
        public byte[] IsEnter { get; set; }
        public long? NpcId { get; set; }

        public virtual Npcs Npc { get; set; }
    }
}
