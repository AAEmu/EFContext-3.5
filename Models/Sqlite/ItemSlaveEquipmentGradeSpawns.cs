namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ItemSlaveEquipmentGradeSpawns
    {
        public long Id { get; set; }
        public string Desc { get; set; }
        public long? DoodadId { get; set; }
        public long? ItemGradeId { get; set; }
        public long? ItemId { get; set; }
        public long? SlaveId { get; set; }

        public virtual ItemTemplate Item { get; set; }
        public virtual ItemGrades ItemGrade { get; set; }
        public virtual Slaves Slave { get; set; }
    }
}
