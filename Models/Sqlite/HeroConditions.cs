using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class HeroConditions
    {
        public HeroConditions()
        {
            Heros = new HashSet<Heros>();
        }

        public long Id { get; set; }
        public string CandidateMailBody { get; set; }
        public string ElectionMailBody { get; set; }
        public string HeroBonusMailBody { get; set; }
        public long? HeroCandidateMinLevel { get; set; }
        public long? HeroCandidateMinPoint { get; set; }
        public long? HeroCandidateScope { get; set; }
        public string HeroNewPeriodTitle { get; set; }
        public long? LeadershipRankingScope { get; set; }
        public long? VotableLeadershipPoint { get; set; }
        public long? VotableLevel { get; set; }
        public string VotingDayTitle { get; set; }
        public string VotingDeyDesc { get; set; }

        public virtual ICollection<Heros> Heros { get; set; }
    }
}
