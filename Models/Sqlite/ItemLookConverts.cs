using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ItemLookConverts
    {
        public ItemLookConverts()
        {
            ItemLookConvertHoldables = new HashSet<ItemLookConvertHoldables>();
            ItemLookConvertRequiredItems = new HashSet<ItemLookConvertRequiredItems>();
            ItemLookConvertWearables = new HashSet<ItemLookConvertWearables>();
            ItemLookRevertRequiredItems = new HashSet<ItemLookRevertRequiredItems>();
        }

        public long Id { get; set; }
        public long? Gold { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ItemLookConvertHoldables> ItemLookConvertHoldables { get; set; }
        public virtual ICollection<ItemLookConvertRequiredItems> ItemLookConvertRequiredItems { get; set; }
        public virtual ICollection<ItemLookConvertWearables> ItemLookConvertWearables { get; set; }
        public virtual ICollection<ItemLookRevertRequiredItems> ItemLookRevertRequiredItems { get; set; }
    }
}
