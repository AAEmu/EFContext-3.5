using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class QuestItemGroups
    {
        public QuestItemGroups()
        {
            QuestItemGroupItems = new HashSet<QuestItemGroupItems>();
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<QuestItemGroupItems> QuestItemGroupItems { get; set; }
    }
}
