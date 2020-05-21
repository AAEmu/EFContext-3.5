using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class BattleFields
    {
        public BattleFields()
        {
            BattleFieldBannedTags = new HashSet<BattleFieldBannedTags>();
            BattleFieldHonorBuffs = new HashSet<BattleFieldHonorBuffs>();
            BattleFieldPickBuffs = new HashSet<BattleFieldPickBuffs>();
            BattleFieldRewards = new HashSet<BattleFieldRewards>();
            GameRuleSets = new HashSet<GameRuleSets>();
        }

        public long Id { get; set; }
        public long? ApplyWaitingTime { get; set; }
        public long? BalanceLevel { get; set; }
        public long? DayOfWeekTime0 { get; set; }
        public long? DayOfWeekTime1 { get; set; }
        public long? DayOfWeekTime2 { get; set; }
        public long? DayOfWeekTime3 { get; set; }
        public long? DayOfWeekTime4 { get; set; }
        public long? DayOfWeekTime5 { get; set; }
        public long? DayOfWeekTime6 { get; set; }
        public long? DayOfWeekTime7 { get; set; }
        public string Desc { get; set; }
        public long? EloRatingScope0 { get; set; }
        public long? EloRatingScope1 { get; set; }
        public long? EloRatingScope2 { get; set; }
        public long? EloRatingScope3 { get; set; }
        public long? EloRatingScope4 { get; set; }
        public long? EloRatingScope5 { get; set; }
        public long? EloRatingScope6 { get; set; }
        public long? EloRatingScope7 { get; set; }
        public long? EloRatingScope8 { get; set; }
        public long? EloRatingScope9 { get; set; }
        public long? EloRatingScope10 { get; set; }
        public long? EnterCount { get; set; }
        public long? FieldKindId { get; set; }
        public long? ItemId { get; set; }
        public long? MatchCleanupTerm { get; set; }
        public long? MatchGradeDiffMax { get; set; }
        public string Name { get; set; }
        public byte[] ShowUi { get; set; }
        public long? ZoneKey { get; set; }

        public virtual ItemTemplate Item { get; set; }
        public virtual ICollection<BattleFieldBannedTags> BattleFieldBannedTags { get; set; }
        public virtual ICollection<BattleFieldHonorBuffs> BattleFieldHonorBuffs { get; set; }
        public virtual ICollection<BattleFieldPickBuffs> BattleFieldPickBuffs { get; set; }
        public virtual ICollection<BattleFieldRewards> BattleFieldRewards { get; set; }
        public virtual ICollection<GameRuleSets> GameRuleSets { get; set; }
    }
}
