namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class QuestMails
    {
        public long Id { get; set; }
        public long? CategoryId { get; set; }
        public string Name { get; set; }
        public long? NpcId { get; set; }
        public long? QuestMailAttachmentId { get; set; }
        public long? SendMoney { get; set; }
        public string SenderName { get; set; }
        public string Text { get; set; }

        public virtual Npcs Npc { get; set; }
        public virtual QuestMailAttachments QuestMailAttachment { get; set; }
    }
}
