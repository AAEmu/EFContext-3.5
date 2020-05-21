namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class SlashCommands
    {
        public long Id { get; set; }
        public string ActionType { get; set; }
        public long? ActionId { get; set; }
        public string CommandList { get; set; }
        public long? SkillId { get; set; }

        public virtual Skills Skill { get; set; }
    }
}
