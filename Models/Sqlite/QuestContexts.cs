using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class QuestContexts
    {
        public QuestContexts()
        {
            QuestActConAcceptComponents = new HashSet<QuestActConAcceptComponents>();
            QuestActObjConditions = new HashSet<QuestActObjConditions>();
            QuestComponents = new HashSet<QuestComponents>();
            QuestContextTexts = new HashSet<QuestContextTexts>();
            QuestNames = new HashSet<QuestNames>();
            TodayQuestGroupQuests = new HashSet<TodayQuestGroupQuests>();
        }

        public long Id { get; set; }
        public long? CategoryId { get; set; }
        public long? ChapterIdx { get; set; }
        public long? Degree { get; set; }
        public long? DetailId { get; set; }
        public long? GradeId { get; set; }
        public byte[] LetItDone { get; set; }
        public long? Level { get; set; }
        public long? MaxLevel { get; set; }
        public long? MinLevel { get; set; }
        public string Name { get; set; }
        public long? Priority { get; set; }
        public long? QuestIdx { get; set; }
        public long? Race { get; set; }
        public byte[] Repeatable { get; set; }
        public byte[] RestartOnFail { get; set; }
        public long? Score { get; set; }
        public byte[] Selective { get; set; }
        public byte[] Successive { get; set; }
        public byte[] UseAcceptMessage { get; set; }
        public byte[] UseCompleteMessage { get; set; }
        public byte[] UseQuestCamera { get; set; }
        public long? ZoneId { get; set; }

        public virtual Zones Zone { get; set; }
        public virtual ICollection<QuestActConAcceptComponents> QuestActConAcceptComponents { get; set; }
        public virtual ICollection<QuestActObjConditions> QuestActObjConditions { get; set; }
        public virtual ICollection<QuestComponents> QuestComponents { get; set; }
        public virtual ICollection<QuestContextTexts> QuestContextTexts { get; set; }
        public virtual ICollection<QuestNames> QuestNames { get; set; }
        public virtual ICollection<TodayQuestGroupQuests> TodayQuestGroupQuests { get; set; }
    }
}
