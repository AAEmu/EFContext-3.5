namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class RankScopeLinks
    {
        public long Id { get; set; }
        public long? RankScopeId { get; set; }
        public long? RankId { get; set; }

        public virtual Ranks Rank { get; set; }
        public virtual RankScopes RankScope { get; set; }
    }
}
