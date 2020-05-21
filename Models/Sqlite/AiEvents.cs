using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class AiEvents
    {
        public AiEvents()
        {
            NpcChatBubbles = new HashSet<NpcChatBubbles>();
        }

        public long Id { get; set; }
        public long? IgnoreCategoryId { get; set; }
        public double? IgnoreTime { get; set; }
        public string Name { get; set; }
        public long? NpcId { get; set; }
        public byte[] OrUnitReqs { get; set; }
        public long? SkillId { get; set; }

        public virtual Npcs Npc { get; set; }
        public virtual Skills Skill { get; set; }
        public virtual ICollection<NpcChatBubbles> NpcChatBubbles { get; set; }
    }
}
