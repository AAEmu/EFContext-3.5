using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class AiFiles
    {
        public AiFiles()
        {
            Npcs = new HashSet<Npcs>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string ParamTemplate { get; set; }

        public virtual ICollection<Npcs> Npcs { get; set; }
    }
}
