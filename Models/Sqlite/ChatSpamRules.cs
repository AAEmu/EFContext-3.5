using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ChatSpamRules
    {
        public ChatSpamRules()
        {
            ChatSpamRuleDetails = new HashSet<ChatSpamRuleDetails>();
        }

        public long Id { get; set; }

        public virtual ICollection<ChatSpamRuleDetails> ChatSpamRuleDetails { get; set; }
    }
}
