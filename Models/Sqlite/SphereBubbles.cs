using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class SphereBubbles
    {
        public SphereBubbles()
        {
            SphereChatBubbles = new HashSet<SphereChatBubbles>();
        }

        public long Id { get; set; }

        public virtual ICollection<SphereChatBubbles> SphereChatBubbles { get; set; }
    }
}
