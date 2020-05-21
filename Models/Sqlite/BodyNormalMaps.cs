using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class BodyNormalMaps
    {
        public BodyNormalMaps()
        {
            TotalCharacterCustoms = new HashSet<TotalCharacterCustoms>();
        }

        public long Id { get; set; }
        public long? DisplayOrder { get; set; }
        public string IconPath { get; set; }
        public byte[] IsNew { get; set; }
        public long? ModelId { get; set; }
        public string Name { get; set; }
        public string Normal { get; set; }
        public byte[] NpcOnly { get; set; }
        public string Specular { get; set; }

        public virtual Models Model { get; set; }
        public virtual ICollection<TotalCharacterCustoms> TotalCharacterCustoms { get; set; }
    }
}
