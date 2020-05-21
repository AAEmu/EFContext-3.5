using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class Npcs
    {
        public Npcs()
        {
            AiEvents = new HashSet<AiEvents>();
            BubbleChats = new HashSet<BubbleChats>();
            ConflictZoneNpcKills = new HashSet<ConflictZoneNpcKills>();
            DoodadFuncAreaTriggers = new HashSet<DoodadFuncAreaTriggers>();
            ItemSummonMates = new HashSet<ItemSummonMates>();
            KillNpcWithoutCorpseEffects = new HashSet<KillNpcWithoutCorpseEffects>();
            MateEquipPacks = new HashSet<MateEquipPacks>();
            MerchantPriceRatios = new HashSet<MerchantPriceRatios>();
            Merchants = new HashSet<Merchants>();
            MonitorNpcs = new HashSet<MonitorNpcs>();
            NpcInitialBuffs = new HashSet<NpcInitialBuffs>();
            NpcMountSkills = new HashSet<NpcMountSkills>();
            QuestActCheckDistances = new HashSet<QuestActCheckDistances>();
            QuestActCheckGuards = new HashSet<QuestActCheckGuards>();
            QuestActConAcceptNpcEmotions = new HashSet<QuestActConAcceptNpcEmotions>();
            QuestActConAcceptNpcKills = new HashSet<QuestActConAcceptNpcKills>();
            QuestActConAcceptNpcs = new HashSet<QuestActConAcceptNpcs>();
            QuestActConReportNpcs = new HashSet<QuestActConReportNpcs>();
            QuestActObjDistances = new HashSet<QuestActObjDistances>();
            QuestActObjMonsterHunts = new HashSet<QuestActObjMonsterHunts>();
            QuestActObjSpheres = new HashSet<QuestActObjSpheres>();
            QuestActObjTalks = new HashSet<QuestActObjTalks>();
            QuestActObjZoneNpcTalks = new HashSet<QuestActObjZoneNpcTalks>();
            QuestChatBubbles = new HashSet<QuestChatBubbles>();
            QuestComponents = new HashSet<QuestComponents>();
            QuestMails = new HashSet<QuestMails>();
            QuestMonsterNpcs = new HashSet<QuestMonsterNpcs>();
            SpecialtyNpcs = new HashSet<SpecialtyNpcs>();
            SphereChatBubbles = new HashSet<SphereChatBubbles>();
            TaggedNpcs = new HashSet<TaggedNpcs>();
        }

        public long Id { get; set; }
        public byte[] AbilityChanger { get; set; }
        public double? AbsoluteReturnDistance { get; set; }
        public byte[] AcceptAggroLink { get; set; }
        public byte[] ActivateAiAlways { get; set; }
        public byte[] Aggression { get; set; }
        public double? AggroLinkHelpDist { get; set; }
        public byte[] AggroLinkSightCheck { get; set; }
        public byte[] AggroLinkSpecialGuard { get; set; }
        public byte[] AggroLinkSpecialIgnoreNpcAttacker { get; set; }
        public long? AggroLinkSpecialRuleId { get; set; }
        public long? AiFileId { get; set; }
        public double? AttackStartRangeScale { get; set; }
        public byte[] Auctioneer { get; set; }
        public byte[] Banker { get; set; }
        public double? BaseSkillDelay { get; set; }
        public byte[] BaseSkillStrafe { get; set; }
        public long? BaseSkillId { get; set; }
        public byte[] BattleFieldRecruiter { get; set; }
        public byte[] Blacksmith { get; set; }
        public long? CharRaceId { get; set; }
        public byte[] CheckBackpack { get; set; }
        public byte[] CheckTargetUnderTerrain { get; set; }
        public byte[] CrowdEffect { get; set; }
        public long? DecayingSecAfterLooted { get; set; }
        public byte[] DontPushableLikeGhost { get; set; }
        public long? EngageCombatGiveQuestId { get; set; }
        public long? EquipClothsId { get; set; }
        public long? EquipWeaponsId { get; set; }
        public long? ExpAdder { get; set; }
        public double? ExpMultiplier { get; set; }
        public byte[] Expedition { get; set; }
        public long? FactionId { get; set; }
        public byte[] ForceTargetMeOnAttack { get; set; }
        public long? HeirLevel { get; set; }
        public long? HonorPoint { get; set; }
        public long? Level { get; set; }
        public byte[] LookConverter { get; set; }
        public long? MateEquipSlotPackId { get; set; }
        public long? MateKindId { get; set; }
        public long? MateReviveDelay { get; set; }
        public long? MateReviveHpPercent { get; set; }
        public long? MateReviveMpPercent { get; set; }
        public byte[] Merchant { get; set; }
        public long? ModelId { get; set; }
        public string Name { get; set; }
        public byte[] NationRelationVote { get; set; }
        public byte[] NoApplyTotalCustom { get; set; }
        public byte[] NoExp { get; set; }
        public byte[] NoPenalty { get; set; }
        public byte[] NonPushableByActor { get; set; }
        public long? NpcAiClientParamId { get; set; }
        public long? NpcAiParamId { get; set; }
        public long? NpcGradeId { get; set; }
        public long? NpcInteractionSetId { get; set; }
        public long? NpcKindId { get; set; }
        public long? NpcNicknameId { get; set; }
        public long? NpcPostureSetId { get; set; }
        public long? NpcStrafeParamId { get; set; }
        public long? NpcTemplateId { get; set; }
        public double? Opacity { get; set; }
        public long? PetItemId { get; set; }
        public byte[] Priest { get; set; }
        public byte[] Repairman { get; set; }
        public double? ReturnDistance { get; set; }
        public byte[] ReturnWhenEnterHousingArea { get; set; }
        public double? Scale { get; set; }
        public byte[] ShowFactionTag { get; set; }
        public byte[] ShowNameTag { get; set; }
        public byte[] ShowOnBossTelescope { get; set; }
        public double? SightFovScale { get; set; }
        public double? SightRangeScale { get; set; }
        public byte[] SkillTrainer { get; set; }
        public string SoState { get; set; }
        public long? SoundPackId { get; set; }
        public byte[] Specialty { get; set; }
        public long? SpecialtyCoinId { get; set; }
        public byte[] Stabler { get; set; }
        public byte[] Teleporter { get; set; }
        public long? TotalCustomId { get; set; }
        public byte[] TrackFriendship { get; set; }
        public byte[] TradegoodBuy { get; set; }
        public byte[] Trader { get; set; }
        public byte[] UseAbuserList { get; set; }
        public byte[] UseDdcmsMountSkill { get; set; }
        public byte[] UseModelCameraDistance { get; set; }
        public byte[] UseRangeMod { get; set; }
        public byte[] VisibleToCreatorOnly { get; set; }

        public virtual AiFiles AiFile { get; set; }
        public virtual MateEquipSlotPacks MateEquipSlotPack { get; set; }
        public virtual Models Model { get; set; }
        public virtual NpcAiClientParams NpcAiClientParam { get; set; }
        public virtual NpcInteractionSets NpcInteractionSet { get; set; }
        public virtual NpcNicknames NpcNickname { get; set; }
        public virtual NpcPostureSets NpcPostureSet { get; set; }
        public virtual NpcStrafeParams NpcStrafeParam { get; set; }
        public virtual SoundPacks SoundPack { get; set; }
        public virtual ICollection<AiEvents> AiEvents { get; set; }
        public virtual ICollection<BubbleChats> BubbleChats { get; set; }
        public virtual ICollection<ConflictZoneNpcKills> ConflictZoneNpcKills { get; set; }
        public virtual ICollection<DoodadFuncAreaTriggers> DoodadFuncAreaTriggers { get; set; }
        public virtual ICollection<ItemSummonMates> ItemSummonMates { get; set; }
        public virtual ICollection<KillNpcWithoutCorpseEffects> KillNpcWithoutCorpseEffects { get; set; }
        public virtual ICollection<MateEquipPacks> MateEquipPacks { get; set; }
        public virtual ICollection<MerchantPriceRatios> MerchantPriceRatios { get; set; }
        public virtual ICollection<Merchants> Merchants { get; set; }
        public virtual ICollection<MonitorNpcs> MonitorNpcs { get; set; }
        public virtual ICollection<NpcInitialBuffs> NpcInitialBuffs { get; set; }
        public virtual ICollection<NpcMountSkills> NpcMountSkills { get; set; }
        public virtual ICollection<QuestActCheckDistances> QuestActCheckDistances { get; set; }
        public virtual ICollection<QuestActCheckGuards> QuestActCheckGuards { get; set; }
        public virtual ICollection<QuestActConAcceptNpcEmotions> QuestActConAcceptNpcEmotions { get; set; }
        public virtual ICollection<QuestActConAcceptNpcKills> QuestActConAcceptNpcKills { get; set; }
        public virtual ICollection<QuestActConAcceptNpcs> QuestActConAcceptNpcs { get; set; }
        public virtual ICollection<QuestActConReportNpcs> QuestActConReportNpcs { get; set; }
        public virtual ICollection<QuestActObjDistances> QuestActObjDistances { get; set; }
        public virtual ICollection<QuestActObjMonsterHunts> QuestActObjMonsterHunts { get; set; }
        public virtual ICollection<QuestActObjSpheres> QuestActObjSpheres { get; set; }
        public virtual ICollection<QuestActObjTalks> QuestActObjTalks { get; set; }
        public virtual ICollection<QuestActObjZoneNpcTalks> QuestActObjZoneNpcTalks { get; set; }
        public virtual ICollection<QuestChatBubbles> QuestChatBubbles { get; set; }
        public virtual ICollection<QuestComponents> QuestComponents { get; set; }
        public virtual ICollection<QuestMails> QuestMails { get; set; }
        public virtual ICollection<QuestMonsterNpcs> QuestMonsterNpcs { get; set; }
        public virtual ICollection<SpecialtyNpcs> SpecialtyNpcs { get; set; }
        public virtual ICollection<SphereChatBubbles> SphereChatBubbles { get; set; }
        public virtual ICollection<TaggedNpcs> TaggedNpcs { get; set; }
    }
}
