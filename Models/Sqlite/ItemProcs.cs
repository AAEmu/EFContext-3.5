using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ItemProcs
    {
        public ItemProcs()
        {
            Holdables = new HashSet<Holdables>();
        }

        public long Id { get; set; }
        public long? ChanceKindId { get; set; }
        public long? ChanceParam { get; set; }
        public long? ChanceRate { get; set; }
        public long? CooldownSec { get; set; }
        public string Description { get; set; }
        public byte[] Finisher { get; set; }
        public long? ItemLevelBasedChanceBonus { get; set; }
        public byte[] OrUnitReqs { get; set; }
        public long? SkillId { get; set; }
        public long? TriggerSkillId { get; set; }
        public long? TriggerTagId { get; set; }

        public virtual Skills Skill { get; set; }
        public virtual ICollection<Holdables> Holdables { get; set; }
    }
}
