using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class DoodadFuncCraftStarts
    {
        public DoodadFuncCraftStarts()
        {
            DoodadFuncCraftStartCrafts = new HashSet<DoodadFuncCraftStartCrafts>();
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<DoodadFuncCraftStartCrafts> DoodadFuncCraftStartCrafts { get; set; }
    }
}
