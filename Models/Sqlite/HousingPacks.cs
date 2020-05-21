using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class HousingPacks
    {
        public HousingPacks()
        {
            GuardTowerStepConds = new HashSet<GuardTowerStepConds>();
            HousingPackMembers = new HashSet<HousingPackMembers>();
        }

        public long Id { get; set; }

        public virtual ICollection<GuardTowerStepConds> GuardTowerStepConds { get; set; }
        public virtual ICollection<HousingPackMembers> HousingPackMembers { get; set; }
    }
}
