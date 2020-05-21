using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class QuestDoodadGroups
    {
        public QuestDoodadGroups()
        {
            QuestActObjInteractions = new HashSet<QuestActObjInteractions>();
            QuestDoodads = new HashSet<QuestDoodads>();
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<QuestActObjInteractions> QuestActObjInteractions { get; set; }
        public virtual ICollection<QuestDoodads> QuestDoodads { get; set; }
    }
}
