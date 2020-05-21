namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class SpecialtyEvents
    {
        public long Id { get; set; }
        public long? EventType { get; set; }
        public long? EventValue { get; set; }
        public long? SpecialtyEventTriggerId { get; set; }

        public virtual SpecialtyEventTriggers SpecialtyEventTrigger { get; set; }
    }
}
