namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ReplaceChatTexts
    {
        public long Id { get; set; }
        public long? ReplaceChatId { get; set; }
        public string Text { get; set; }

        public virtual ReplaceChats ReplaceChat { get; set; }
    }
}
