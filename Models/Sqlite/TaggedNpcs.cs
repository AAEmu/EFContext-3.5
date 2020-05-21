namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class TaggedNpcs
    {
        public long Id { get; set; }
        public long? NpcId { get; set; }
        public long? TagId { get; set; }

        public virtual Npcs Npc { get; set; }
        public virtual Tags Tag { get; set; }
    }
}
