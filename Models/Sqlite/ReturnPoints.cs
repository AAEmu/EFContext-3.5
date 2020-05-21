using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ReturnPoints
    {
        public ReturnPoints()
        {
            DistrictReturnPoints = new HashSet<DistrictReturnPoints>();
            DoodadFuncExitInduns = new HashSet<DoodadFuncExitInduns>();
        }

        public long Id { get; set; }
        public string EditorName { get; set; }
        public string Name { get; set; }

        public virtual ICollection<DistrictReturnPoints> DistrictReturnPoints { get; set; }
        public virtual ICollection<DoodadFuncExitInduns> DoodadFuncExitInduns { get; set; }
    }
}
