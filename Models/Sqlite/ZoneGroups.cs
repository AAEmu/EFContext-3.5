using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ZoneGroups
    {
        public ZoneGroups()
        {
            ConflictZones = new HashSet<ConflictZones>();
            DoodadFuncZoneReacts = new HashSet<DoodadFuncZoneReacts>();
            FestivalZones = new HashSet<FestivalZones>();
            IndunZones = new HashSet<IndunZones>();
            LocalDevelopments = new HashSet<LocalDevelopments>();
            QuestActObjConquestWars = new HashSet<QuestActObjConquestWars>();
            Ranks = new HashSet<Ranks>();
            SiegeZones = new HashSet<SiegeZones>();
            SpecialtyEventTriggers = new HashSet<SpecialtyEventTriggers>();
            ZoneGroupBannedTags = new HashSet<ZoneGroupBannedTags>();
            ZoneWaitings = new HashSet<ZoneWaitings>();
        }

        public long Id { get; set; }
        public long? BuffId { get; set; }
        public string DisplayText { get; set; }
        public byte[] EnablePhysicsCollisionDamage { get; set; }
        public long? FactionId { get; set; }
        public long? FactionChatRegionId { get; set; }
        public long? FishingLandLootPackId { get; set; }
        public long? FishingSeaLootPackId { get; set; }
        public double? H { get; set; }
        public long? ImageMap { get; set; }
        public string Name { get; set; }
        public byte[] PirateDesperado { get; set; }
        public long? SoundId { get; set; }
        public long? SoundPackId { get; set; }
        public long? TargetId { get; set; }
        public double? W { get; set; }
        public double? X { get; set; }
        public double? Y { get; set; }

        public virtual Buffs Buff { get; set; }
        public virtual FactionChatRegions FactionChatRegion { get; set; }
        public virtual Sounds Sound { get; set; }
        public virtual SoundPacks SoundPack { get; set; }
        public virtual ICollection<ConflictZones> ConflictZones { get; set; }
        public virtual ICollection<DoodadFuncZoneReacts> DoodadFuncZoneReacts { get; set; }
        public virtual ICollection<FestivalZones> FestivalZones { get; set; }
        public virtual ICollection<IndunZones> IndunZones { get; set; }
        public virtual ICollection<LocalDevelopments> LocalDevelopments { get; set; }
        public virtual ICollection<QuestActObjConquestWars> QuestActObjConquestWars { get; set; }
        public virtual ICollection<Ranks> Ranks { get; set; }
        public virtual ICollection<SiegeZones> SiegeZones { get; set; }
        public virtual ICollection<SpecialtyEventTriggers> SpecialtyEventTriggers { get; set; }
        public virtual ICollection<ZoneGroupBannedTags> ZoneGroupBannedTags { get; set; }
        public virtual ICollection<ZoneWaitings> ZoneWaitings { get; set; }
    }
}
