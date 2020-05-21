namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class HousingPackMembers
    {
        public long Id { get; set; }
        public long? HousingPackId { get; set; }
        public long? HousingId { get; set; }

        public virtual Housings Housing { get; set; }
        public virtual HousingPacks HousingPack { get; set; }
    }
}
