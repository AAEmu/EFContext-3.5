namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class DoodadFuncMouldItems
    {
        public long Id { get; set; }
        public long? DoodadFuncMouldId { get; set; }
        public long? MouldPackId { get; set; }

        public virtual DoodadFuncMoulds DoodadFuncMould { get; set; }
        public virtual MouldPacks MouldPack { get; set; }
    }
}
