using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class HousingGroups
    {
        public HousingGroups()
        {
            HousingAreas = new HashSet<HousingAreas>();
            HousingGroupCategories = new HashSet<HousingGroupCategories>();
        }

        public long Id { get; set; }
        public long? AllowedTaxDelayWeek { get; set; }
        public byte[] CanExtend { get; set; }
        public string Desc { get; set; }
        public long? DoodadId { get; set; }
        public long? ExistingCategoryId { get; set; }
        public byte[] Houseless { get; set; }
        public string Name { get; set; }

        public virtual ICollection<HousingAreas> HousingAreas { get; set; }
        public virtual ICollection<HousingGroupCategories> HousingGroupCategories { get; set; }
    }
}
