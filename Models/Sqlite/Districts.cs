using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class Districts
    {
        public Districts()
        {
            DistrictReturnPoints = new HashSet<DistrictReturnPoints>();
            DoodadFuncBindings = new HashSet<DoodadFuncBindings>();
        }

        public long Id { get; set; }
        public long? KindId { get; set; }

        public virtual ICollection<DistrictReturnPoints> DistrictReturnPoints { get; set; }
        public virtual ICollection<DoodadFuncBindings> DoodadFuncBindings { get; set; }
    }
}
