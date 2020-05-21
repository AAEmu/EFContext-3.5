namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class CommonFarms
    {
        public long Id { get; set; }
        public string Comments { get; set; }
        public long? FarmGroupId { get; set; }
        public long? GuardTime { get; set; }
        public string Name { get; set; }

        public virtual FarmGroups FarmGroup { get; set; }
    }
}
