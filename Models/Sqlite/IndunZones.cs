namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class IndunZones
    {
        public long? ZoneGroupId { get; set; }
        public byte[] ClientDriven { get; set; }
        public byte[] Duel { get; set; }
        public long? EnterCount { get; set; }
        public byte[] ExpPanelty { get; set; }
        public byte[] HasGraveyard { get; set; }
        public long? ItemId { get; set; }
        public long? LevelMax { get; set; }
        public long? LevelMin { get; set; }
        public long? MaxPlayers { get; set; }
        public string Name { get; set; }
        public byte[] PartyOnly { get; set; }
        public byte[] Pvp { get; set; }
        public long? RestoreItemTime { get; set; }
        public byte[] SelectChannel { get; set; }

        public virtual ItemTemplate Item { get; set; }
        public virtual ZoneGroups ZoneGroup { get; set; }
    }
}
