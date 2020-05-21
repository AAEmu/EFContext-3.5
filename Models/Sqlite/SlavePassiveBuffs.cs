namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class SlavePassiveBuffs
    {
        public string OwnerType { get; set; }
        public long? OwnerId { get; set; }
        public long? PassiveBuffId { get; set; }

        public virtual PassiveBuffs PassiveBuff { get; set; }
    }
}
