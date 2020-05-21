namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class HousingAreas
    {
        public long Id { get; set; }
        public byte[] Activated { get; set; }
        public long? AtDay { get; set; }
        public long? AtHour { get; set; }
        public long? AtMin { get; set; }
        public long? AtMonth { get; set; }
        public long? AtYear { get; set; }
        public byte[] ExceptBattle { get; set; }
        public byte[] ExceptChaosWar { get; set; }
        public byte[] ExceptSiege { get; set; }
        public byte[] ExceptWar { get; set; }
        public long? HousingGroupId { get; set; }
        public string Name { get; set; }
        public long? ProtectFactionId { get; set; }

        public virtual HousingGroups HousingGroup { get; set; }
    }
}
