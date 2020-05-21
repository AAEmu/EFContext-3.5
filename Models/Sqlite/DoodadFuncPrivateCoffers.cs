using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class DoodadFuncPrivateCoffers
    {
        public DoodadFuncPrivateCoffers()
        {
            DoodadFuncPrivateCofferItemCategories = new HashSet<DoodadFuncPrivateCofferItemCategories>();
        }

        public long Id { get; set; }
        public long? Capacity { get; set; }

        public virtual ICollection<DoodadFuncPrivateCofferItemCategories> DoodadFuncPrivateCofferItemCategories { get; set; }
    }
}
