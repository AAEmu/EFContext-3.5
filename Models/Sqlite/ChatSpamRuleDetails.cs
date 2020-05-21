namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ChatSpamRuleDetails
    {
        public long Id { get; set; }
        public long? ChatSpamRuleId { get; set; }
        public long? DetectedCaseNextDetailId { get; set; }
        public byte[] EndNode { get; set; }
        public long? NotDetectedCaseNextDetailId { get; set; }
        public byte[] StartNode { get; set; }
        public string Text { get; set; }

        public virtual ChatSpamRules ChatSpamRule { get; set; }
    }
}
