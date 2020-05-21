using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class QuestContextGroups
    {
        public QuestContextGroups()
        {
            QuestActObjCompleteQuestGroups = new HashSet<QuestActObjCompleteQuestGroups>();
            QuestContextGroupMembers = new HashSet<QuestContextGroupMembers>();
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<QuestActObjCompleteQuestGroups> QuestActObjCompleteQuestGroups { get; set; }
        public virtual ICollection<QuestContextGroupMembers> QuestContextGroupMembers { get; set; }
    }
}
