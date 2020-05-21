namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ChatCommands
    {
        public long Id { get; set; }
        public long? ChatTypeId { get; set; }
        public byte[] Enable { get; set; }
        public long? MenuOrder { get; set; }
        public string Name { get; set; }
        public byte[] NotifyChatDelay { get; set; }
        public long? SpendItemCount { get; set; }
        public long? SpendItemId { get; set; }
    }
}
