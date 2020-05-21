namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class SphereBuffs
    {
        public long Id { get; set; }
        public byte[] AndPet { get; set; }
        public long? BuffId { get; set; }
        public long? RemoveOnLeaveBuffId { get; set; }

        public virtual Buffs Buff { get; set; }
    }
}
