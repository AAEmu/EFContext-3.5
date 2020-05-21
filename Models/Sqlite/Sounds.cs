using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class Sounds
    {
        public Sounds()
        {
            BubbleChats = new HashSet<BubbleChats>();
            CombatSounds = new HashSet<CombatSounds>();
            DoodadFuncGroups = new HashSet<DoodadFuncGroups>();
            DoodadFuncPuzzleOuts = new HashSet<DoodadFuncPuzzleOuts>();
            DoodadFuncs = new HashSet<DoodadFuncs>();
            FxParticles = new HashSet<FxParticles>();
            FxSounds = new HashSet<FxSounds>();
            QuestChatBubbles = new HashSet<QuestChatBubbles>();
            QuestComponents = new HashSet<QuestComponents>();
            SoundPackItems = new HashSet<SoundPackItems>();
            SphereChatBubbles = new HashSet<SphereChatBubbles>();
            SphereSounds = new HashSet<SphereSounds>();
            SubZones = new HashSet<SubZones>();
            VehicleModels = new HashSet<VehicleModels>();
            ZoneGroups = new HashSet<ZoneGroups>();
        }

        public long Id { get; set; }
        public long? CategoryId { get; set; }
        public long? EndMethodId { get; set; }
        public long? LevelId { get; set; }
        public string Path { get; set; }

        public virtual Levels Level { get; set; }
        public virtual ICollection<BubbleChats> BubbleChats { get; set; }
        public virtual ICollection<CombatSounds> CombatSounds { get; set; }
        public virtual ICollection<DoodadFuncGroups> DoodadFuncGroups { get; set; }
        public virtual ICollection<DoodadFuncPuzzleOuts> DoodadFuncPuzzleOuts { get; set; }
        public virtual ICollection<DoodadFuncs> DoodadFuncs { get; set; }
        public virtual ICollection<FxParticles> FxParticles { get; set; }
        public virtual ICollection<FxSounds> FxSounds { get; set; }
        public virtual ICollection<QuestChatBubbles> QuestChatBubbles { get; set; }
        public virtual ICollection<QuestComponents> QuestComponents { get; set; }
        public virtual ICollection<SoundPackItems> SoundPackItems { get; set; }
        public virtual ICollection<SphereChatBubbles> SphereChatBubbles { get; set; }
        public virtual ICollection<SphereSounds> SphereSounds { get; set; }
        public virtual ICollection<SubZones> SubZones { get; set; }
        public virtual ICollection<VehicleModels> VehicleModels { get; set; }
        public virtual ICollection<ZoneGroups> ZoneGroups { get; set; }
    }
}
