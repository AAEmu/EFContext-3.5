namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class EquipItemSetBonuses
    {
        public long Id { get; set; }
        public long? BuffId { get; set; }
        public long? EquipItemSetId { get; set; }
        public long? NumPieces { get; set; }
        public long? ProcId { get; set; }

        public virtual Buffs Buff { get; set; }
        public virtual EquipItemSets EquipItemSet { get; set; }
    }
}
