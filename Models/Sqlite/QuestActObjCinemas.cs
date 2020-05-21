namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class QuestActObjCinemas
    {
        public long Id { get; set; }
        public long? CinemaId { get; set; }
        public long? QuestActObjAliasId { get; set; }
        public byte[] UseAlias { get; set; }

        public virtual Cinemas Cinema { get; set; }
    }
}
