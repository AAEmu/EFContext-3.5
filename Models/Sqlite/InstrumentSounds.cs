namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class InstrumentSounds
    {
        public long Id { get; set; }
        public long? BuffId { get; set; }
        public long? ItemId { get; set; }
        public long? KindId { get; set; }
        public long? Midi { get; set; }

        public virtual Buffs Buff { get; set; }
        public virtual ItemTemplate Item { get; set; }
    }
}
