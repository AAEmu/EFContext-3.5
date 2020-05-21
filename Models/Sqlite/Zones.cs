using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class Zones
    {
        public Zones()
        {
            DoodadFuncBindings = new HashSet<DoodadFuncBindings>();
            DoodadFuncEnterInstances = new HashSet<DoodadFuncEnterInstances>();
            DoodadFuncEnterSysInstances = new HashSet<DoodadFuncEnterSysInstances>();
            DoodadFuncRemoveInstances = new HashSet<DoodadFuncRemoveInstances>();
            DoodadFuncSpawnMgmts = new HashSet<DoodadFuncSpawnMgmts>();
            QuestActObjZoneKills = new HashSet<QuestActObjZoneKills>();
            QuestActObjZoneMonsterHunts = new HashSet<QuestActObjZoneMonsterHunts>();
            QuestActObjZoneQuestCompletes = new HashSet<QuestActObjZoneQuestCompletes>();
            QuestContexts = new HashSet<QuestContexts>();
            RaceTracks = new HashSet<RaceTracks>();
        }

        public long Id { get; set; }
        public byte[] Closed { get; set; }
        public string DisplayText { get; set; }
        public long? FactionId { get; set; }
        public long? GroupId { get; set; }
        public string Name { get; set; }
        public long? ZoneClimateId { get; set; }
        public long? ZoneKey { get; set; }

        public virtual ZoneClimates ZoneClimate { get; set; }
        public virtual ICollection<DoodadFuncBindings> DoodadFuncBindings { get; set; }
        public virtual ICollection<DoodadFuncEnterInstances> DoodadFuncEnterInstances { get; set; }
        public virtual ICollection<DoodadFuncEnterSysInstances> DoodadFuncEnterSysInstances { get; set; }
        public virtual ICollection<DoodadFuncRemoveInstances> DoodadFuncRemoveInstances { get; set; }
        public virtual ICollection<DoodadFuncSpawnMgmts> DoodadFuncSpawnMgmts { get; set; }
        public virtual ICollection<QuestActObjZoneKills> QuestActObjZoneKills { get; set; }
        public virtual ICollection<QuestActObjZoneMonsterHunts> QuestActObjZoneMonsterHunts { get; set; }
        public virtual ICollection<QuestActObjZoneQuestCompletes> QuestActObjZoneQuestCompletes { get; set; }
        public virtual ICollection<QuestContexts> QuestContexts { get; set; }
        public virtual ICollection<RaceTracks> RaceTracks { get; set; }
    }
}
