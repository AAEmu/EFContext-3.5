namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class BuffTickEffects
    {
        public long Id { get; set; }
        public long? BuffId { get; set; }
        public byte[] CheckNoTargetTagSrc { get; set; }
        public byte[] CheckTargetTagSrc { get; set; }
        public long? EffectId { get; set; }
        public long? TargetBuffTagId { get; set; }
        public long? TargetNobuffTagId { get; set; }

        public virtual Buffs Buff { get; set; }
        public virtual Effects Effect { get; set; }
    }
}
