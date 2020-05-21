namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class DoodadFuncFxGroupCallbacks
    {
        public long Id { get; set; }
        public long? CallbackTypeId { get; set; }
        public long? Duration { get; set; }
        public long? FxGroupId { get; set; }
        public byte[] InteractorOnly { get; set; }

        public virtual FxGroups FxGroup { get; set; }
    }
}
