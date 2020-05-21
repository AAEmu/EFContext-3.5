namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class DoodadFuncs
    {
        public long Id { get; set; }
        public long? ActCount { get; set; }
        public string ActualFuncType { get; set; }
        public long? ActualFuncId { get; set; }
        public long? DoodadFuncGroupId { get; set; }
        public byte[] ForbidOnClimb { get; set; }
        public long? FuncSkillId { get; set; }
        public long? NextPhase { get; set; }
        public long? PermId { get; set; }
        public byte[] PopupWarn { get; set; }
        public long? SoundId { get; set; }

        public virtual DoodadFuncGroups DoodadFuncGroup { get; set; }
        public virtual Sounds Sound { get; set; }
    }
}
