using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class QuestComponents
    {
        public QuestComponents()
        {
            QuestActs = new HashSet<QuestActs>();
            QuestChatBubbles = new HashSet<QuestChatBubbles>();
            QuestComponentTexts = new HashSet<QuestComponentTexts>();
        }

        public long Id { get; set; }
        public long? AiCommandSetId { get; set; }
        public string AiPathName { get; set; }
        public long? AiPathTypeId { get; set; }
        public long? BuffId { get; set; }
        public long? CinemaId { get; set; }
        public long? ComponentKindId { get; set; }
        public byte[] HideQuestMarker { get; set; }
        public long? NextComponent { get; set; }
        public long? NpcAiId { get; set; }
        public long? NpcSpawnerId { get; set; }
        public long? NpcId { get; set; }
        public byte[] OrUnitReqs { get; set; }
        public byte[] PlayCinemaBeforeBubble { get; set; }
        public long? QuestContextId { get; set; }
        public byte[] SkillSelf { get; set; }
        public long? SkillId { get; set; }
        public long? SoundId { get; set; }
        public long? SummaryVoiceId { get; set; }

        public virtual Buffs Buff { get; set; }
        public virtual Cinemas Cinema { get; set; }
        public virtual Npcs Npc { get; set; }
        public virtual QuestContexts QuestContext { get; set; }
        public virtual Skills Skill { get; set; }
        public virtual Sounds Sound { get; set; }
        public virtual ICollection<QuestActs> QuestActs { get; set; }
        public virtual ICollection<QuestChatBubbles> QuestChatBubbles { get; set; }
        public virtual ICollection<QuestComponentTexts> QuestComponentTexts { get; set; }
    }
}
