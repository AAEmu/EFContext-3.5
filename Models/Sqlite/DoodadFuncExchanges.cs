using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class DoodadFuncExchanges
    {
        public DoodadFuncExchanges()
        {
            DoodadFuncExchangeItems = new HashSet<DoodadFuncExchangeItems>();
        }

        public long Id { get; set; }

        public virtual ICollection<DoodadFuncExchangeItems> DoodadFuncExchangeItems { get; set; }
    }
}
