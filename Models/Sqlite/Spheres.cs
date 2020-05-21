using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class Spheres
    {
        public Spheres()
        {
            QuestActCheckSpheres = new HashSet<QuestActCheckSpheres>();
            QuestActConAcceptSpheres = new HashSet<QuestActConAcceptSpheres>();
            QuestActObjSpheres = new HashSet<QuestActObjSpheres>();
        }

        public long Id { get; set; }
        public long? CategoryId { get; set; }
        public byte[] EnterOrLeave { get; set; }
        public byte[] IsPersonalMsg { get; set; }
        public string Name { get; set; }
        public byte[] OrUnitReqs { get; set; }
        public string SphereDetailType { get; set; }
        public long? SphereDetailId { get; set; }
        public string TeamMsg { get; set; }
        public long? TriggerConditionId { get; set; }
        public long? TriggerConditionTime { get; set; }
        public long? WatchDoodadId { get; set; }

        public virtual ICollection<QuestActCheckSpheres> QuestActCheckSpheres { get; set; }
        public virtual ICollection<QuestActConAcceptSpheres> QuestActConAcceptSpheres { get; set; }
        public virtual ICollection<QuestActObjSpheres> QuestActObjSpheres { get; set; }
    }
}
