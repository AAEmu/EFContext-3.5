﻿namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class QuestActSupplyRemoveItems
    {
        public long Id { get; set; }
        public long? Count { get; set; }
        public long? ItemId { get; set; }

        public virtual ItemTemplate Item { get; set; }
    }
}
