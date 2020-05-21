namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class BuffTriggers
    {
        public long Id { get; set; }
        public long? BuffId { get; set; }
        public byte[] CheckNoTagSrcInOwner { get; set; }
        public byte[] CheckNoTagSrcInSource { get; set; }
        public byte[] CheckNoTagSrcInTarget { get; set; }
        public byte[] CheckTagSrcInOwner { get; set; }
        public byte[] CheckTagSrcInSource { get; set; }
        public byte[] CheckTagSrcInTarget { get; set; }
        public long? DelayTime { get; set; }
        public long? EffectId { get; set; }
        public long? EventId { get; set; }
        public long? OwnerBuffTagId { get; set; }
        public long? OwnerNoBuffTagId { get; set; }
        public long? SourceAgentId { get; set; }
        public long? SourceBuffTagId { get; set; }
        public long? SourceNoBuffTagId { get; set; }
        public long? TargetAgentId { get; set; }
        public long? TargetBuffTagId { get; set; }
        public long? TargetNoBuffTagId { get; set; }
        public byte[] UseCollisionImpact { get; set; }
        public byte[] UseDamageAmount { get; set; }
        public byte[] UseStackCount { get; set; }

        public virtual Buffs Buff { get; set; }
        public virtual Effects Effect { get; set; }
    }
}
