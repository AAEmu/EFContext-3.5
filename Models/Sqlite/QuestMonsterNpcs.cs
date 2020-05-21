namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class QuestMonsterNpcs
    {
        public long Id { get; set; }
        public long? NpcId { get; set; }
        public long? QuestMonsterGroupId { get; set; }

        public virtual Npcs Npc { get; set; }
        public virtual QuestMonsterGroups QuestMonsterGroup { get; set; }
    }
}
