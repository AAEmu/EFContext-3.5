using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class CustomDualMaterials
    {
        public CustomDualMaterials()
        {
            Buffs = new HashSet<Buffs>();
            FxMaterials = new HashSet<FxMaterials>();
        }

        public long Id { get; set; }
        public string Filename { get; set; }

        public virtual ICollection<Buffs> Buffs { get; set; }
        public virtual ICollection<FxMaterials> FxMaterials { get; set; }
    }
}
