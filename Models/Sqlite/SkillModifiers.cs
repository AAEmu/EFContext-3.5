namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class SkillModifiers
    {
        public string OwnerType { get; set; }
        public long? OwnerId { get; set; }
        public long? SkillAttributeId { get; set; }
        public long? SkillId { get; set; }
        public byte[] Synergy { get; set; }
        public long? TagId { get; set; }
        public long? UnitModifierTypeId { get; set; }
        public long? Value { get; set; }

        public virtual Skills Skill { get; set; }
        public virtual Tags Tag { get; set; }
    }
}
