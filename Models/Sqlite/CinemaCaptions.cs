namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class CinemaCaptions
    {
        public long Id { get; set; }
        public string Caption { get; set; }
        public long? CinemaId { get; set; }

        public virtual Cinemas Cinema { get; set; }
    }
}
