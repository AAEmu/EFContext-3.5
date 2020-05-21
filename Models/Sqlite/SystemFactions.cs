using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class SystemFactions
    {
        public SystemFactions()
        {
            ZoneWaitingFactions = new HashSet<ZoneWaitingFactions>();
        }

        public long Id { get; set; }
        public byte[] AggroLink { get; set; }
        public long? DiplomacyLinkId { get; set; }
        public byte[] GuardHelp { get; set; }
        public string IconPath { get; set; }
        public byte[] IsDiplomacyTgt { get; set; }
        public long? MotherId { get; set; }
        public string Name { get; set; }
        public long? OwnerId { get; set; }
        public string OwnerName { get; set; }
        public long? OwnerTypeId { get; set; }
        public long? PoliticalSystemId { get; set; }

        public virtual ICollection<ZoneWaitingFactions> ZoneWaitingFactions { get; set; }
    }
}
