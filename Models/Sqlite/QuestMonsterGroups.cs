using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class QuestMonsterGroups
    {
        public QuestMonsterGroups()
        {
            QuestActConAcceptNpcGroups = new HashSet<QuestActConAcceptNpcGroups>();
            QuestActConReportNpcGroups = new HashSet<QuestActConReportNpcGroups>();
            QuestActObjMonsterGroupHunts = new HashSet<QuestActObjMonsterGroupHunts>();
            QuestMonsterNpcs = new HashSet<QuestMonsterNpcs>();
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<QuestActConAcceptNpcGroups> QuestActConAcceptNpcGroups { get; set; }
        public virtual ICollection<QuestActConReportNpcGroups> QuestActConReportNpcGroups { get; set; }
        public virtual ICollection<QuestActObjMonsterGroupHunts> QuestActObjMonsterGroupHunts { get; set; }
        public virtual ICollection<QuestMonsterNpcs> QuestMonsterNpcs { get; set; }
    }
}
