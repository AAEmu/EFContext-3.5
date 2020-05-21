using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ExpertLimits
    {
        public ExpertLimits()
        {
            IntensifiedExpertLimits = new HashSet<IntensifiedExpertLimits>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public long? UpLimit { get; set; }
        public long? ExpertLimit { get; set; }
        public long? Advantage { get; set; }
        public long? CastAdv { get; set; }
        public long? ColorArgb { get; set; }
        public long? GaugeColor { get; set; }
        public long? UpCurrencyId { get; set; }
        public long? UpPrice { get; set; }
        public long? DownCurrencyId { get; set; }
        public long? DownPrice { get; set; }
        public byte[] Show { get; set; }
        public long? ExpMul { get; set; }
        public byte[] UseIntensified { get; set; }

        public virtual ICollection<IntensifiedExpertLimits> IntensifiedExpertLimits { get; set; }
    }
}
