namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ItemLookConvertHoldables
    {
        public long Id { get; set; }
        public long? HoldableId { get; set; }
        public long? ItemLookConvertId { get; set; }

        public virtual Holdables Holdable { get; set; }
        public virtual ItemLookConverts ItemLookConvert { get; set; }
    }
}
