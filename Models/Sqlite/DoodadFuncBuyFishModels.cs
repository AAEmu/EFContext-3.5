using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class DoodadFuncBuyFishModels
    {
        public DoodadFuncBuyFishModels()
        {
            DoodadFuncBuyFishModelItems = new HashSet<DoodadFuncBuyFishModelItems>();
        }

        public long Id { get; set; }

        public virtual ICollection<DoodadFuncBuyFishModelItems> DoodadFuncBuyFishModelItems { get; set; }
    }
}
