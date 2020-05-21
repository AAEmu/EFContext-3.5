using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class WearableSlots
    {
        public WearableSlots()
        {
            ItemLookConvertWearables = new HashSet<ItemLookConvertWearables>();
        }

        public long Id { get; set; }
        public long? Coverage { get; set; }
        public long? GearScoreMultiplier { get; set; }
        public long? SlotTypeId { get; set; }

        public virtual ICollection<ItemLookConvertWearables> ItemLookConvertWearables { get; set; }
    }
}
