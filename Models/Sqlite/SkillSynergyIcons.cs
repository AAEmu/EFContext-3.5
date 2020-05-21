namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class SkillSynergyIcons
    {
        public long Id { get; set; }
        public long? BuffTagId { get; set; }
        public byte[] ConditionBuffkind { get; set; }
        public long? ConditionIconId { get; set; }
        public string Desc { get; set; }
        public byte[] ResultBuffkind { get; set; }
        public long? ResultIconId { get; set; }
        public long? SkillId { get; set; }
        public long? UnitSelectionId { get; set; }

        public virtual Skills Skill { get; set; }
    }
}
