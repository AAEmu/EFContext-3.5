namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class CharacterDefaultSkills
    {
        public long? CharacterId { get; set; }
        public long? DefaultSkillId { get; set; }

        public virtual Characters Character { get; set; }
        public virtual DefaultSkills DefaultSkill { get; set; }
    }
}
