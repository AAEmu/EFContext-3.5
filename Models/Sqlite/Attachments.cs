using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class Attachments
    {
        public Attachments()
        {
            AttachmentAnims = new HashSet<AttachmentAnims>();
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<AttachmentAnims> AttachmentAnims { get; set; }
    }
}
