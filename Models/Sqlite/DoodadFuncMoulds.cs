using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class DoodadFuncMoulds
    {
        public DoodadFuncMoulds()
        {
            DoodadFuncMouldItems = new HashSet<DoodadFuncMouldItems>();
        }

        public long Id { get; set; }

        public virtual ICollection<DoodadFuncMouldItems> DoodadFuncMouldItems { get; set; }
    }
}
