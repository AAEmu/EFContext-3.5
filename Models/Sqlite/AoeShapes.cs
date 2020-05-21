using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class AoeShapes
    {
        public AoeShapes()
        {
            DoodadFuncClouts = new HashSet<DoodadFuncClouts>();
        }

        public long Id { get; set; }
        public byte[] AdjustAngle { get; set; }
        public long? AreaTargetKindId { get; set; }
        public byte[] CalcDistance { get; set; }
        public long? KindId { get; set; }
        public double? Value1 { get; set; }
        public double? Value2 { get; set; }
        public double? Value3 { get; set; }

        public virtual ICollection<DoodadFuncClouts> DoodadFuncClouts { get; set; }
    }
}
