using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class PassiveBuffs
    {
        public PassiveBuffs()
        {
            BuffPassiveBuffs = new HashSet<BuffPassiveBuffs>();
            SlavePassiveBuffs = new HashSet<SlavePassiveBuffs>();
        }

        public long Id { get; set; }
        public long? AbilityId { get; set; }
        public byte[] Active { get; set; }
        public long? BuffId { get; set; }
        public long? HighAbilityId { get; set; }
        public long? Level { get; set; }
        public long? ReqPoints { get; set; }
        public long? SkillPoints { get; set; }

        public virtual Buffs Buff { get; set; }
        public virtual ICollection<BuffPassiveBuffs> BuffPassiveBuffs { get; set; }
        public virtual ICollection<SlavePassiveBuffs> SlavePassiveBuffs { get; set; }
    }
}
