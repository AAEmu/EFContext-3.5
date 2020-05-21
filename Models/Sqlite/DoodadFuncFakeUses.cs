namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class DoodadFuncFakeUses
    {
        public long Id { get; set; }
        public long? FakeSkillId { get; set; }
        public long? SkillId { get; set; }
        public byte[] TargetParent { get; set; }

        public virtual Skills Skill { get; set; }
    }
}
