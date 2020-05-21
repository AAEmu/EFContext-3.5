using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class QuestMailAttachments
    {
        public QuestMailAttachments()
        {
            QuestMails = new HashSet<QuestMails>();
        }

        public long Id { get; set; }

        public virtual ICollection<QuestMails> QuestMails { get; set; }
    }
}
