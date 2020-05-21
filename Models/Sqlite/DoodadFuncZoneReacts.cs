namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class DoodadFuncZoneReacts
    {
        public long Id { get; set; }
        public long? NextPhase { get; set; }
        public long? ZoneGroupId { get; set; }

        public virtual ZoneGroups ZoneGroup { get; set; }
    }
}
