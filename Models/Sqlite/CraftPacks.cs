using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class CraftPacks
    {
        public CraftPacks()
        {
            CraftPackCrafts = new HashSet<CraftPackCrafts>();
            DoodadFuncCraftPacks = new HashSet<DoodadFuncCraftPacks>();
        }

        public long Id { get; set; }

        public virtual ICollection<CraftPackCrafts> CraftPackCrafts { get; set; }
        public virtual ICollection<DoodadFuncCraftPacks> DoodadFuncCraftPacks { get; set; }
    }
}
