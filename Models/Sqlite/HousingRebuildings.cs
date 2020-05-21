using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class HousingRebuildings
    {
        public HousingRebuildings()
        {
            HousingRebuildingMaterials = new HashSet<HousingRebuildingMaterials>();
            HousingRebuildingPackRebuildings = new HashSet<HousingRebuildingPackRebuildings>();
        }

        public long Id { get; set; }
        public long? ActabilityGroupId { get; set; }
        public string ChangePointDesc { get; set; }
        public long? HousingId { get; set; }
        public long? LaborPower { get; set; }
        public string Name { get; set; }
        public long? SkillId { get; set; }

        public virtual ActabilityGroups ActabilityGroup { get; set; }
        public virtual Housings Housing { get; set; }
        public virtual Skills Skill { get; set; }
        public virtual ICollection<HousingRebuildingMaterials> HousingRebuildingMaterials { get; set; }
        public virtual ICollection<HousingRebuildingPackRebuildings> HousingRebuildingPackRebuildings { get; set; }
    }
}
