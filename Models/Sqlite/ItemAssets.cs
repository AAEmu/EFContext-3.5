using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ItemAssets
    {
        public ItemAssets()
        {
            ItemAssetTransforms = new HashSet<ItemAssetTransforms>();
        }

        public long Id { get; set; }
        public byte[] AllowMirror { get; set; }
        public double? AttachmentOffsetPosX { get; set; }
        public double? AttachmentOffsetPosY { get; set; }
        public double? AttachmentOffsetPosZ { get; set; }
        public double? AttachmentOffsetRotX { get; set; }
        public double? AttachmentOffsetRotY { get; set; }
        public double? AttachmentOffsetRotZ { get; set; }
        public string DefaultAnim { get; set; }
        public long? Detail { get; set; }
        public double? HeelOffsetHeight { get; set; }
        public byte[] HideHorn { get; set; }
        public byte[] HideTail { get; set; }
        public double? HingeDamping { get; set; }
        public long? HingeIdx { get; set; }
        public double? HingeLimit { get; set; }
        public long? ModelId { get; set; }
        public long? MoreAssetId { get; set; }
        public double? NameTagOffsetHeight { get; set; }
        public string Path { get; set; }

        public virtual Models Model { get; set; }
        public virtual ICollection<ItemAssetTransforms> ItemAssetTransforms { get; set; }
    }
}
