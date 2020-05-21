namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class NationMemberLimits
    {
        public long Id { get; set; }
        public long? DominionCount { get; set; }
        public long? MemberCount { get; set; }
    }
}
