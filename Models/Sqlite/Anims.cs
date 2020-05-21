using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class Anims
    {
        public Anims()
        {
            AttachmentAnims = new HashSet<AttachmentAnims>();
            ExpressTexts = new HashSet<ExpressTexts>();
        }

        public long Id { get; set; }
        public long? CategoryId { get; set; }
        public string HangUb { get; set; }
        public byte[] Loop { get; set; }
        public string MoveUb { get; set; }
        public string Name { get; set; }
        public string RelaxedUb { get; set; }
        public string RideUb { get; set; }
        public string SwimMoveUb { get; set; }
        public string SwimUb { get; set; }

        public virtual ICollection<AttachmentAnims> AttachmentAnims { get; set; }
        public virtual ICollection<ExpressTexts> ExpressTexts { get; set; }
    }
}
