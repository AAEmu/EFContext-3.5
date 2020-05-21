namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class GameRuleSets
    {
        public long Id { get; set; }
        public long? BattleFieldId { get; set; }
        public long? BonusWinner { get; set; }
        public long? BonusNoDeath { get; set; }
        public long? BonusTopEnemyPcKill { get; set; }
        public long? BonusTopEnemyNonPcKill { get; set; }
        public long? BonusLoser { get; set; }
        public long? Corps1Id { get; set; }
        public long? Corps2Id { get; set; }
        public long? CorpsSize { get; set; }
        public long? DeathstreakId { get; set; }
        public long? GameRuleModeId { get; set; }
        public long? GameTypeId { get; set; }
        public long? Killstreak0Id { get; set; }
        public long? Killstreak1Id { get; set; }
        public long? Killstreak2Id { get; set; }
        public long? Killstreak3Id { get; set; }
        public long? Killstreak4Id { get; set; }
        public long? Killstreak5Id { get; set; }
        public long? Killstreak6Id { get; set; }
        public long? Killstreak7Id { get; set; }
        public long? Killstreak8Id { get; set; }
        public long? Killstreak9Id { get; set; }
        public long? Killstreak10Id { get; set; }
        public long? Killstreak11Id { get; set; }
        public long? Killstreak12Id { get; set; }
        public long? Killstreak13Id { get; set; }
        public long? Killstreak14Id { get; set; }
        public long? Killstreak15Id { get; set; }
        public long? Killstreak16Id { get; set; }
        public long? Killstreak17Id { get; set; }
        public long? Killstreak18Id { get; set; }
        public long? Killstreak19Id { get; set; }
        public long? Killstreak20Id { get; set; }
        public long? Killstreak21Id { get; set; }
        public long? Killstreak22Id { get; set; }
        public long? Killstreak23Id { get; set; }
        public long? LevelMax { get; set; }
        public long? LevelMin { get; set; }
        public long? MinCorpsSize { get; set; }
        public string ModeCustomData { get; set; }
        public long? PlayRoundCount { get; set; }
        public long? RankInvalidPoint { get; set; }
        public long? RankLosePoint { get; set; }
        public long? RankWinPoint { get; set; }
        public long? RankDrawPoint { get; set; }
        public byte[] RoundWinAllKillCorps { get; set; }
        public long? RoundWinDefaultId { get; set; }
        public long? TimeAutoResurrection { get; set; }
        public long? TimeEnding { get; set; }
        public long? TimeOpening { get; set; }
        public long? TimePlaying { get; set; }
        public long? TimeReady { get; set; }
        public long? TimeRespawnDeadBuilding { get; set; }
        public long? TimeResurrectionDelay { get; set; }
        public long? TimeUnearnedWin { get; set; }
        public long? VictoryDefaultId { get; set; }
        public long? VictoryKillCorps1Head { get; set; }
        public long? VictoryKillCorps2Head { get; set; }
        public long? VictoryKillCount { get; set; }
        public long? VictoryRankScope { get; set; }
        public long? VictoryRoundWinCount { get; set; }
        public long? VictoryScore { get; set; }
        public long? WinnerMultiplier { get; set; }
        public long? WinnerMultiplierInterval { get; set; }

        public virtual BattleFields BattleField { get; set; }
    }
}
