using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class FxItems
    {
        public FxItems()
        {
            FxGroupFxItems = new HashSet<FxGroupFxItems>();
        }

        public long Id { get; set; }
        public string AssetName { get; set; }
        public long? BoneId { get; set; }
        public string FxDetailType { get; set; }
        public long? FxDetailId { get; set; }
        public long? FxEventEndId { get; set; }
        public long? FxEventStartId { get; set; }
        public long? FxLocationId { get; set; }
        public long? FxScaleId { get; set; }
        public long? OffsetAxisId { get; set; }
        public double? OffsetX { get; set; }
        public double? OffsetY { get; set; }
        public double? OffsetZ { get; set; }

        public virtual ICollection<FxGroupFxItems> FxGroupFxItems { get; set; }
    }
}
