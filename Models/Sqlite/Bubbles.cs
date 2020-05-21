using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class Bubbles
    {
        public Bubbles()
        {
            BubbleChats = new HashSet<BubbleChats>();
            DoodadFuncBubbles = new HashSet<DoodadFuncBubbles>();
        }

        public long Id { get; set; }

        public virtual ICollection<BubbleChats> BubbleChats { get; set; }
        public virtual ICollection<DoodadFuncBubbles> DoodadFuncBubbles { get; set; }
    }
}
