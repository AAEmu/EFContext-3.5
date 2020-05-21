using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class SpecialtyEventTriggers
    {
        public SpecialtyEventTriggers()
        {
            SpecialtyEvents = new HashSet<SpecialtyEvents>();
        }

        public long Id { get; set; }
        public long? CheckTime { get; set; }
        public long? EventRate { get; set; }
        public long? EventTime { get; set; }
        public long? ItemId { get; set; }
        public long? MsgType { get; set; }
        public string MsgEnd { get; set; }
        public string MsgStart { get; set; }
        public long? TriggerType { get; set; }
        public long? TriggerValue1 { get; set; }
        public long? TriggerValue2 { get; set; }
        public long? ZoneGroupId { get; set; }

        public virtual ItemTemplate Item { get; set; }
        public virtual ZoneGroups ZoneGroup { get; set; }
        public virtual ICollection<SpecialtyEvents> SpecialtyEvents { get; set; }
    }
}
