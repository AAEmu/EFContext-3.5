using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class Shipyards
    {
        public Shipyards()
        {
            ItemShipyards = new HashSet<ItemShipyards>();
            ShipyardRewards = new HashSet<ShipyardRewards>();
            ShipyardSteps = new HashSet<ShipyardSteps>();
        }

        public long Id { get; set; }
        public long? BuildRadius { get; set; }
        public string CeremonyAnimKey { get; set; }
        public long? CeremonyAnimTime { get; set; }
        public long? CeremonyModelId { get; set; }
        public long? ItemId { get; set; }
        public long? MainModelId { get; set; }
        public string Name { get; set; }
        public long? OriginItemId { get; set; }
        public double? SpawnOffsetFront { get; set; }
        public double? SpawnOffsetZ { get; set; }
        public long? TaxDuration { get; set; }
        public long? TaxationId { get; set; }

        public virtual ItemTemplate Item { get; set; }
        public virtual Taxations Taxation { get; set; }
        public virtual ICollection<ItemShipyards> ItemShipyards { get; set; }
        public virtual ICollection<ShipyardRewards> ShipyardRewards { get; set; }
        public virtual ICollection<ShipyardSteps> ShipyardSteps { get; set; }
    }
}
