using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class MouldPacks
    {
        public MouldPacks()
        {
            DoodadFuncMouldItems = new HashSet<DoodadFuncMouldItems>();
            MouldPackItems = new HashSet<MouldPackItems>();
        }

        public long Id { get; set; }

        public virtual ICollection<DoodadFuncMouldItems> DoodadFuncMouldItems { get; set; }
        public virtual ICollection<MouldPackItems> MouldPackItems { get; set; }
    }
}
