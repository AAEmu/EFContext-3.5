namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ItemCapScales
    {
        public long? SkillId { get; set; }
        public long Id { get; set; }
        public long? ScaleMin { get; set; }
        public long? ScaleMax { get; set; }

        public virtual Skills Skill { get; set; }
    }
}
