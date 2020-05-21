using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class DoodadFuncGroups
    {
        public DoodadFuncGroups()
        {
            DoodadFuncs = new HashSet<DoodadFuncs>();
            DoodadPhaseFuncs = new HashSet<DoodadPhaseFuncs>();
        }

        public long Id { get; set; }
        public string Color { get; set; }
        public long? DoodadAlmightyId { get; set; }
        public long? DoodadFuncGroupKindId { get; set; }
        public string IconKey { get; set; }
        public byte[] IsMsgToWorld { get; set; }
        public byte[] IsMsgToZone { get; set; }
        public string Model { get; set; }
        public long? MsgToFactionId { get; set; }
        public string Name { get; set; }
        public long? OverHeadMarkGap { get; set; }
        public string PhaseMsg { get; set; }
        public long? SoundTime { get; set; }
        public long? SoundId { get; set; }
        public string TitleColor { get; set; }
        public string TitleMsg { get; set; }
        public byte[] UseUiMsg { get; set; }

        public virtual Sounds Sound { get; set; }
        public virtual ICollection<DoodadFuncs> DoodadFuncs { get; set; }
        public virtual ICollection<DoodadPhaseFuncs> DoodadPhaseFuncs { get; set; }
    }
}
