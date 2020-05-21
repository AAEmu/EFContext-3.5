namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class DoodadPhaseFuncs
    {
        public long Id { get; set; }
        public string ActualFuncType { get; set; }
        public long? ActualFuncId { get; set; }
        public long? DoodadFuncGroupId { get; set; }

        public virtual DoodadFuncGroups DoodadFuncGroup { get; set; }
    }
}
