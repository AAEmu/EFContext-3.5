namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class KillNpcWithoutCorpseEffects
    {
        public long Id { get; set; }
        public byte[] GiveExp { get; set; }
        public long? NpcId { get; set; }
        public double? Radius { get; set; }
        public byte[] Vanish { get; set; }

        public virtual Npcs Npc { get; set; }
    }
}
