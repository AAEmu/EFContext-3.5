using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class OpenPortalEffects
    {
        public OpenPortalEffects()
        {
            OpenPortalInlandReagents = new HashSet<OpenPortalInlandReagents>();
            OpenPortalOutlandReagents = new HashSet<OpenPortalOutlandReagents>();
        }

        public long Id { get; set; }
        public double? Distance { get; set; }

        public virtual ICollection<OpenPortalInlandReagents> OpenPortalInlandReagents { get; set; }
        public virtual ICollection<OpenPortalOutlandReagents> OpenPortalOutlandReagents { get; set; }
    }
}
