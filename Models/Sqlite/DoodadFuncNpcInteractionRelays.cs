namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class DoodadFuncNpcInteractionRelays
    {
        public long Id { get; set; }
        public double? Range { get; set; }
        public long? TagId { get; set; }

        public virtual Tags Tag { get; set; }
    }
}
