namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class FestivalZones
    {
        public long? ZoneGroupId { get; set; }
        public byte[] Closed { get; set; }
        public long? EdDay { get; set; }
        public long? EdHour { get; set; }
        public long? EdMin { get; set; }
        public long? EdMonth { get; set; }
        public long? EdYear { get; set; }
        public long? HariharaReturnPointId { get; set; }
        public string Name { get; set; }
        public long? NationReturnPointId { get; set; }
        public long? NuiaReturnPointId { get; set; }
        public long? PirateReturnPointId { get; set; }
        public long? StDay { get; set; }
        public long? StHour { get; set; }
        public long? StMin { get; set; }
        public long? StMonth { get; set; }
        public long? StYear { get; set; }

        public virtual ZoneGroups ZoneGroup { get; set; }
    }
}
