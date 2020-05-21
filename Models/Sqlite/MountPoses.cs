using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class MountPoses
    {
        public MountPoses()
        {
            AnimActions = new HashSet<AnimActions>();
            Models = new HashSet<Models>();
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<AnimActions> AnimActions { get; set; }
        public virtual ICollection<Models> Models { get; set; }
    }
}
