namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class QuestDoodads
    {
        public long Id { get; set; }
        public long? DoodadId { get; set; }
        public long? QuestDoodadGroupId { get; set; }

        public virtual QuestDoodadGroups QuestDoodadGroup { get; set; }
    }
}
