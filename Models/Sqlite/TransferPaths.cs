namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class TransferPaths
    {
        public string OwnerType { get; set; }
        public long? OwnerId { get; set; }
        public string PathName { get; set; }
        public double? WaitTimeEnd { get; set; }
        public double? WaitTimeStart { get; set; }
    }
}
