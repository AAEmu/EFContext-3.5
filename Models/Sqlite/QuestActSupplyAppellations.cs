namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class QuestActSupplyAppellations
    {
        public long Id { get; set; }
        public long? AppellationId { get; set; }

        public virtual Appellations Appellation { get; set; }
    }
}
