namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class DoodadFuncEvidenceItemLoots
    {
        public long Id { get; set; }
        public long? CrimeKindId { get; set; }
        public long? CrimeValue { get; set; }
        public long? SkillId { get; set; }

        public virtual Skills Skill { get; set; }
    }
}
