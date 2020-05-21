using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class SpecialtyBundles
    {
        public SpecialtyBundles()
        {
            SpecialtyBundleItems = new HashSet<SpecialtyBundleItems>();
            SpecialtyNpcs = new HashSet<SpecialtyNpcs>();
        }

        public long Id { get; set; }

        public virtual ICollection<SpecialtyBundleItems> SpecialtyBundleItems { get; set; }
        public virtual ICollection<SpecialtyNpcs> SpecialtyNpcs { get; set; }
    }
}
