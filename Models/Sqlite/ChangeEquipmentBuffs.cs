namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ChangeEquipmentBuffs
    {
        public string OwnerType { get; set; }
        public long? OwnerId { get; set; }
        public long? BuffId { get; set; }

        public virtual Buffs Buff { get; set; }
    }
}
