namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class AttachmentAnims
    {
        public string OwnerType { get; set; }
        public long? OwnerId { get; set; }
        public long? AnimId { get; set; }
        public long? AttachmentId { get; set; }
        public long? KindId { get; set; }

        public virtual Anims Anim { get; set; }
        public virtual Attachments Attachment { get; set; }
    }
}
