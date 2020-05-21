using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ReplaceChats
    {
        public ReplaceChats()
        {
            ReplaceChatKeys = new HashSet<ReplaceChatKeys>();
            ReplaceChatTexts = new HashSet<ReplaceChatTexts>();
        }

        public long Id { get; set; }

        public virtual ICollection<ReplaceChatKeys> ReplaceChatKeys { get; set; }
        public virtual ICollection<ReplaceChatTexts> ReplaceChatTexts { get; set; }
    }
}
