using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class Cinemas
    {
        public Cinemas()
        {
            CinemaCaptions = new HashSet<CinemaCaptions>();
            Housings = new HashSet<Housings>();
            QuestActObjCinemas = new HashSet<QuestActObjCinemas>();
            QuestComponents = new HashSet<QuestComponents>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public byte[] Replay { get; set; }

        public virtual ICollection<CinemaCaptions> CinemaCaptions { get; set; }
        public virtual ICollection<Housings> Housings { get; set; }
        public virtual ICollection<QuestActObjCinemas> QuestActObjCinemas { get; set; }
        public virtual ICollection<QuestComponents> QuestComponents { get; set; }
    }
}
