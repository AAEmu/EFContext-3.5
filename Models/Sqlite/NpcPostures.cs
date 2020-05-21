namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class NpcPostures
    {
        public long Id { get; set; }
        public long? AnimActionId { get; set; }
        public long? NpcPostureSetId { get; set; }
        public long? StartTodTime { get; set; }
        public string TalkAnim { get; set; }

        public virtual AnimActions AnimAction { get; set; }
        public virtual NpcPostureSets NpcPostureSet { get; set; }
    }
}
