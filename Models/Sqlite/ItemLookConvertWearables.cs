namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ItemLookConvertWearables
    {
        public long Id { get; set; }
        public long? ItemCategoryId { get; set; }
        public long? ItemLookConvertId { get; set; }
        public long? WearableSlotId { get; set; }

        public virtual ItemLookConverts ItemLookConvert { get; set; }
        public virtual WearableSlots WearableSlot { get; set; }
    }
}
