using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ItemSmeltings
    {
        public ItemSmeltings()
        {
            ItemSmeltingItems = new HashSet<ItemSmeltingItems>();
        }

        public long Id { get; set; }
        public long? ActabilityLimit { get; set; }
        public long? Amount { get; set; }
        public long? Gold { get; set; }
        public long? ItemSetId { get; set; }
        public long? ItemSmeltingProbId { get; set; }
        public long? ItemId { get; set; }
        public long? SkillId { get; set; }

        public virtual ItemTemplate Item { get; set; }
        public virtual ItemSets ItemSet { get; set; }
        public virtual Skills Skill { get; set; }
        public virtual ICollection<ItemSmeltingItems> ItemSmeltingItems { get; set; }
    }
}
