using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class FarmGroups
    {
        public FarmGroups()
        {
            CommonFarms = new HashSet<CommonFarms>();
            FarmGroupDoodads = new HashSet<FarmGroupDoodads>();
        }

        public long Id { get; set; }
        public long? Count { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }

        public virtual ICollection<CommonFarms> CommonFarms { get; set; }
        public virtual ICollection<FarmGroupDoodads> FarmGroupDoodads { get; set; }
    }
}
