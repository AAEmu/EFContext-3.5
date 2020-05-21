using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class Taxations
    {
        public Taxations()
        {
            Housings = new HashSet<Housings>();
            Shipyards = new HashSet<Shipyards>();
        }

        public long Id { get; set; }
        public string Desc { get; set; }
        public long? SealCount { get; set; }
        public byte[] Show { get; set; }
        public long? Tax { get; set; }

        public virtual ICollection<Housings> Housings { get; set; }
        public virtual ICollection<Shipyards> Shipyards { get; set; }
    }
}
