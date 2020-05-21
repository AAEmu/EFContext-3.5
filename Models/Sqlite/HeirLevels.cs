namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class HeirLevels
    {
        public long Id { get; set; }
        public long? Level { get; set; }
        public long? ReqItemCount { get; set; }
        public long? ReqItemId { get; set; }
        public long? ReqTotalExp { get; set; }
        public long? Step { get; set; }
    }
}
