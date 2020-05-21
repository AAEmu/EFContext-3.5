namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ReplaceChatKeys
    {
        public long Id { get; set; }
        public string Key { get; set; }
        public long? ReplaceChatId { get; set; }

        public virtual ReplaceChats ReplaceChat { get; set; }
    }
}
