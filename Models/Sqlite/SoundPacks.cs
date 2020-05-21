using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class SoundPacks
    {
        public SoundPacks()
        {
            FxParticles = new HashSet<FxParticles>();
            Models = new HashSet<Models>();
            Npcs = new HashSet<Npcs>();
            SoundPackItems = new HashSet<SoundPackItems>();
            SubZones = new HashSet<SubZones>();
            ZoneGroups = new HashSet<ZoneGroups>();
        }

        public long Id { get; set; }
        public byte[] NoMoodNoSound { get; set; }

        public virtual ICollection<FxParticles> FxParticles { get; set; }
        public virtual ICollection<Models> Models { get; set; }
        public virtual ICollection<Npcs> Npcs { get; set; }
        public virtual ICollection<SoundPackItems> SoundPackItems { get; set; }
        public virtual ICollection<SubZones> SubZones { get; set; }
        public virtual ICollection<ZoneGroups> ZoneGroups { get; set; }
    }
}
