namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ConflictZones
    {
        public long? ZoneGroupId { get; set; }
        public byte[] AutoTeam { get; set; }
        public byte[] AutoTeamDismiss { get; set; }
        public byte[] Closed { get; set; }
        public long? ConflictMin { get; set; }
        public long? HariharaReturnPointId { get; set; }
        public long? NationReturnPointId { get; set; }
        public long? NoKillMin0 { get; set; }
        public long? NoKillMin1 { get; set; }
        public long? NoKillMin2 { get; set; }
        public long? NoKillMin3 { get; set; }
        public long? NoKillMin4 { get; set; }
        public long? NuiaReturnPointId { get; set; }
        public long? NumKills0 { get; set; }
        public long? NumKills1 { get; set; }
        public long? NumKills2 { get; set; }
        public long? NumKills3 { get; set; }
        public long? NumKills4 { get; set; }
        public long? PeaceMin { get; set; }
        public long? PeaceProtectedFactionId { get; set; }
        public long? PeaceTowerDefId { get; set; }
        public long? PirateReturnPointId { get; set; }
        public byte[] WarChaos { get; set; }
        public long? WarMin { get; set; }
        public long? WarStHour0 { get; set; }
        public long? WarStHour1 { get; set; }
        public long? WarStHour2 { get; set; }
        public long? WarStHour3 { get; set; }
        public long? WarStHour4 { get; set; }
        public long? WarStMin0 { get; set; }
        public long? WarStMin1 { get; set; }
        public long? WarStMin2 { get; set; }
        public long? WarStMin3 { get; set; }
        public long? WarStMin4 { get; set; }
        public long? WarTowerDefId { get; set; }
        public double? WarDropMul { get; set; }
        public double? WarGoldMul { get; set; }
        public double? PeaceDropMul { get; set; }
        public double? PeaceGoldMul { get; set; }
        public long? NumNpcKills0 { get; set; }
        public long? NumNpcKills1 { get; set; }
        public long? NumNpcKills2 { get; set; }
        public long? NumNpcKills3 { get; set; }
        public long? NumNpcKills4 { get; set; }
        public long? NumQuestCompletions0 { get; set; }
        public long? NumQuestCompletions1 { get; set; }
        public long? NumQuestCompletions2 { get; set; }
        public long? NumQuestCompletions3 { get; set; }
        public long? NumQuestCompletions4 { get; set; }
        public long? ZoneDamageMultiplierKindId { get; set; }

        public virtual ZoneGroups ZoneGroup { get; set; }
    }
}
