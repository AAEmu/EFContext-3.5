namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class NpcInteractions
    {
        public long Id { get; set; }
        public long? NpcInteractionSetId { get; set; }
        public long? SkillId { get; set; }

        public virtual NpcInteractionSets NpcInteractionSet { get; set; }
        public virtual Skills Skill { get; set; }
    }
}
