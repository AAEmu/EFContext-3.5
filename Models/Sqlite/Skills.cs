using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class Skills
    {
        public Skills()
        {
            AiEvents = new HashSet<AiEvents>();
            BuffSkills = new HashSet<BuffSkills>();
            Crafts = new HashSet<Crafts>();
            DefaultSkills = new HashSet<DefaultSkills>();
            DoodadFuncConditionalUses = new HashSet<DoodadFuncConditionalUses>();
            DoodadFuncEvidenceItemLoots = new HashSet<DoodadFuncEvidenceItemLoots>();
            DoodadFuncFakeUses = new HashSet<DoodadFuncFakeUses>();
            DoodadFuncItemChangers = new HashSet<DoodadFuncItemChangers>();
            DoodadFuncReactDevotes = new HashSet<DoodadFuncReactDevotes>();
            DoodadFuncRenewItems = new HashSet<DoodadFuncRenewItems>();
            DoodadFuncSkillHits = new HashSet<DoodadFuncSkillHits>();
            DoodadFuncUses = new HashSet<DoodadFuncUses>();
            Gimmicks = new HashSet<Gimmicks>();
            HeirSkillDetails = new HashSet<HeirSkillDetails>();
            HeirSkills = new HashSet<HeirSkills>();
            HousingBuildSteps = new HashSet<HousingBuildSteps>();
            HousingRebuildings = new HashSet<HousingRebuildings>();
            ItemCapScales = new HashSet<ItemCapScales>();
            ItemProcs = new HashSet<ItemProcs>();
            ItemSmeltings = new HashSet<ItemSmeltings>();
            MountAttachedSkills = new HashSet<MountAttachedSkills>();
            MountSkills = new HashSet<MountSkills>();
            NpcInteractions = new HashSet<NpcInteractions>();
            QuestActCheckTimers = new HashSet<QuestActCheckTimers>();
            QuestActConAcceptSkills = new HashSet<QuestActConAcceptSkills>();
            QuestActSupplySkills = new HashSet<QuestActSupplySkills>();
            QuestComponents = new HashSet<QuestComponents>();
            ShipyardSteps = new HashSet<ShipyardSteps>();
            SkillDynamicEffects = new HashSet<SkillDynamicEffects>();
            SkillEffects = new HashSet<SkillEffects>();
            SkillModifiers = new HashSet<SkillModifiers>();
            SkillProducts = new HashSet<SkillProducts>();
            SkillReagents = new HashSet<SkillReagents>();
            SkillReqSkills = new HashSet<SkillReqSkills>();
            SkillSynergyIcons = new HashSet<SkillSynergyIcons>();
            SlashCommands = new HashSet<SlashCommands>();
            SlaveInteractionSkills = new HashSet<SlaveInteractionSkills>();
            SphereDoodadInteracts = new HashSet<SphereDoodadInteracts>();
            SphereSkills = new HashSet<SphereSkills>();
            TaggedSkills = new HashSet<TaggedSkills>();
            TooltipSkillEffects = new HashSet<TooltipSkillEffects>();
        }

        public long Id { get; set; }
        public long? AbilityId { get; set; }
        public long? AbilityLevel { get; set; }
        public byte[] AccountCooldown { get; set; }
        public long? ActabilityGroupId { get; set; }
        public long? ActiveWeaponId { get; set; }
        public long? Aggro { get; set; }
        public byte[] AllowToPrisoner { get; set; }
        public byte[] AutoFire { get; set; }
        public byte[] AutoLearn { get; set; }
        public byte[] AutoReuse { get; set; }
        public long? AutoReuseDelay { get; set; }
        public byte[] CalcUserLevel { get; set; }
        public double? CameraAcceleration { get; set; }
        public double? CameraDuration { get; set; }
        public byte[] CameraHoldZ { get; set; }
        public double? CameraMaxDistance { get; set; }
        public double? CameraSlowDownDistance { get; set; }
        public double? CameraSpeed { get; set; }
        public byte[] CanActiveWeaponWithoutAnim { get; set; }
        public long? CancelOngoingBuffExceptionTagId { get; set; }
        public byte[] CancelOngoingBuffs { get; set; }
        public byte[] CastingCancelable { get; set; }
        public byte[] CastingDelayable { get; set; }
        public long? CastingInc { get; set; }
        public long? CastingTime { get; set; }
        public byte[] CastingUseable { get; set; }
        public long? CategoryId { get; set; }
        public long? ChannelingAnimId { get; set; }
        public long? ChannelingBuffId { get; set; }
        public byte[] ChannelingCancelable { get; set; }
        public long? ChannelingDoodadId { get; set; }
        public long? ChannelingMana { get; set; }
        public long? ChannelingTargetBuffId { get; set; }
        public long? ChannelingTick { get; set; }
        public long? ChannelingTime { get; set; }
        public long? CharRaceId { get; set; }
        public byte[] CheckObstacle { get; set; }
        public byte[] CheckTerrain { get; set; }
        public long? CombatDiceId { get; set; }
        public long? ConsumeLp { get; set; }
        public byte[] ControllerCamera { get; set; }
        public long? ControllerCameraSpeed { get; set; }
        public long? CooldownTagId { get; set; }
        public long? CooldownTime { get; set; }
        public long? Cost { get; set; }
        public long? CrimePoint { get; set; }
        public long? CustomGcd { get; set; }
        public long? DamageTypeId { get; set; }
        public byte[] DefaultGcd { get; set; }
        public string Desc { get; set; }
        public long? DoodadBundleId { get; set; }
        public long? DoodadHitFamily { get; set; }
        public long? DualWieldFireAnimId { get; set; }
        public long? EffectDelay { get; set; }
        public long? EffectRepeatCount { get; set; }
        public long? EffectRepeatTick { get; set; }
        public double? EffectSpeed { get; set; }
        public byte[] EndSkillController { get; set; }
        public long? FireAnimId { get; set; }
        public byte[] FirstReagentOnly { get; set; }
        public long? FrontAngle { get; set; }
        public long? FxGroupId { get; set; }
        public long? GainLifePoint { get; set; }
        public long? HighAbilityId { get; set; }
        public long? IconId { get; set; }
        public byte[] IgnoreGlobalCooldown { get; set; }
        public byte[] KeepManaRegen { get; set; }
        public byte[] KeepStealth { get; set; }
        public byte[] LevelRuleNoConsideration { get; set; }
        public long? LevelStep { get; set; }
        public long? LinkBackpackTypeId { get; set; }
        public long? LinkEquipSlotId { get; set; }
        public long? MainhandToolId { get; set; }
        public long? ManaCost { get; set; }
        public double? ManaLevelMd { get; set; }
        public byte[] MatchAnimation { get; set; }
        public byte[] MatchAnimationCount { get; set; }
        public long? MaxHighAbilityResource { get; set; }
        public long? MaxRange { get; set; }
        public long? MinHighAbilityResource { get; set; }
        public long? MinRange { get; set; }
        public string Name { get; set; }
        public long? OffhandToolId { get; set; }
        public byte[] OrUnitReqs { get; set; }
        public long? PercussionInstrumentFireAnimId { get; set; }
        public long? PercussionInstrumentStartAnimId { get; set; }
        public double? PitchAngle { get; set; }
        public byte[] PlotOnly { get; set; }
        public long? PlotId { get; set; }
        public long? ProjectileId { get; set; }
        public long? ReagentCorpseStatusId { get; set; }
        public long? RepeatCount { get; set; }
        public long? RepeatTick { get; set; }
        public long? SecondCooldownTagId { get; set; }
        public byte[] SensitiveOperation { get; set; }
        public byte[] Show { get; set; }
        public byte[] ShowTargetCastingTime { get; set; }
        public long? SkillControllerId { get; set; }
        public byte[] SkillControllerAtEnd { get; set; }
        public long? SkillPoints { get; set; }
        public byte[] SkipQuestApplyUseItem { get; set; }
        public byte[] SkipValidateSource { get; set; }
        public byte[] SourceAlive { get; set; }
        public byte[] SourceCannotUseWhileWalk { get; set; }
        public byte[] SourceDead { get; set; }
        public byte[] SourceMount { get; set; }
        public byte[] SourceMountMate { get; set; }
        public byte[] SourceNoSlave { get; set; }
        public byte[] SourceNotCollided { get; set; }
        public byte[] SourceNotSwim { get; set; }
        public byte[] SourceStun { get; set; }
        public long? StartAnimId { get; set; }
        public byte[] StartAutoattack { get; set; }
        public byte[] StopAutoattack { get; set; }
        public byte[] StopCastingByTurn { get; set; }
        public byte[] StopCastingOnBigHit { get; set; }
        public byte[] StopChannelingOnBigHit { get; set; }
        public byte[] StopChannelingOnStartSkill { get; set; }
        public long? StringInstrumentFireAnimId { get; set; }
        public long? StringInstrumentStartAnimId { get; set; }
        public byte[] SwitchToSkillCooldown { get; set; }
        public byte[] SynergyIcon1Buffkind { get; set; }
        public long? SynergyIcon1Id { get; set; }
        public byte[] SynergyIcon2Buffkind { get; set; }
        public long? SynergyIcon2Id { get; set; }
        public byte[] TargetAlive { get; set; }
        public long? TargetAngle { get; set; }
        public long? TargetAreaAngle { get; set; }
        public long? TargetAreaCount { get; set; }
        public long? TargetAreaRadius { get; set; }
        public byte[] TargetDead { get; set; }
        public long? TargetDecalRadius { get; set; }
        public byte[] TargetFishing { get; set; }
        public byte[] TargetMyNpc { get; set; }
        public double? TargetOffsetAngle { get; set; }
        public double? TargetOffsetDistance { get; set; }
        public byte[] TargetOnlyWater { get; set; }
        public byte[] TargetPreoccupied { get; set; }
        public long? TargetRelationId { get; set; }
        public long? TargetSelectionId { get; set; }
        public byte[] TargetSiege { get; set; }
        public long? TargetTypeId { get; set; }
        public double? TargetValidHeight { get; set; }
        public byte[] TargetWater { get; set; }
        public long? ThirdCooldownTagId { get; set; }
        public long? TimingId { get; set; }
        public long? ToggleBuffId { get; set; }
        public long? TubeInstrumentFireAnimId { get; set; }
        public long? TubeInstrumentStartAnimId { get; set; }
        public long? TwohandFireAnimId { get; set; }
        public byte[] Unmount { get; set; }
        public byte[] UseAnimTime { get; set; }
        public byte[] UseSkillCamera { get; set; }
        public byte[] UseWeaponCooldownTime { get; set; }
        public double? ValidHeight { get; set; }
        public byte[] ValidHeightEdgeToEdge { get; set; }
        public long? WeaponSlotForAngleId { get; set; }
        public long? WeaponSlotForAutoattackId { get; set; }
        public long? WeaponSlotForRangeId { get; set; }

        public virtual ActabilityGroups ActabilityGroup { get; set; }
        public virtual DoodadBundles DoodadBundle { get; set; }
        public virtual FxGroups FxGroup { get; set; }
        public virtual Icons Icon { get; set; }
        public virtual Plots Plot { get; set; }
        public virtual Projectiles Projectile { get; set; }
        public virtual SkillControllers SkillController { get; set; }
        public virtual ICollection<AiEvents> AiEvents { get; set; }
        public virtual ICollection<BuffSkills> BuffSkills { get; set; }
        public virtual ICollection<Crafts> Crafts { get; set; }
        public virtual ICollection<DefaultSkills> DefaultSkills { get; set; }
        public virtual ICollection<DoodadFuncConditionalUses> DoodadFuncConditionalUses { get; set; }
        public virtual ICollection<DoodadFuncEvidenceItemLoots> DoodadFuncEvidenceItemLoots { get; set; }
        public virtual ICollection<DoodadFuncFakeUses> DoodadFuncFakeUses { get; set; }
        public virtual ICollection<DoodadFuncItemChangers> DoodadFuncItemChangers { get; set; }
        public virtual ICollection<DoodadFuncReactDevotes> DoodadFuncReactDevotes { get; set; }
        public virtual ICollection<DoodadFuncRenewItems> DoodadFuncRenewItems { get; set; }
        public virtual ICollection<DoodadFuncSkillHits> DoodadFuncSkillHits { get; set; }
        public virtual ICollection<DoodadFuncUses> DoodadFuncUses { get; set; }
        public virtual ICollection<Gimmicks> Gimmicks { get; set; }
        public virtual ICollection<HeirSkillDetails> HeirSkillDetails { get; set; }
        public virtual ICollection<HeirSkills> HeirSkills { get; set; }
        public virtual ICollection<HousingBuildSteps> HousingBuildSteps { get; set; }
        public virtual ICollection<HousingRebuildings> HousingRebuildings { get; set; }
        public virtual ICollection<ItemCapScales> ItemCapScales { get; set; }
        public virtual ICollection<ItemProcs> ItemProcs { get; set; }
        public virtual ICollection<ItemSmeltings> ItemSmeltings { get; set; }
        public virtual ICollection<MountAttachedSkills> MountAttachedSkills { get; set; }
        public virtual ICollection<MountSkills> MountSkills { get; set; }
        public virtual ICollection<NpcInteractions> NpcInteractions { get; set; }
        public virtual ICollection<QuestActCheckTimers> QuestActCheckTimers { get; set; }
        public virtual ICollection<QuestActConAcceptSkills> QuestActConAcceptSkills { get; set; }
        public virtual ICollection<QuestActSupplySkills> QuestActSupplySkills { get; set; }
        public virtual ICollection<QuestComponents> QuestComponents { get; set; }
        public virtual ICollection<ShipyardSteps> ShipyardSteps { get; set; }
        public virtual ICollection<SkillDynamicEffects> SkillDynamicEffects { get; set; }
        public virtual ICollection<SkillEffects> SkillEffects { get; set; }
        public virtual ICollection<SkillModifiers> SkillModifiers { get; set; }
        public virtual ICollection<SkillProducts> SkillProducts { get; set; }
        public virtual ICollection<SkillReagents> SkillReagents { get; set; }
        public virtual ICollection<SkillReqSkills> SkillReqSkills { get; set; }
        public virtual ICollection<SkillSynergyIcons> SkillSynergyIcons { get; set; }
        public virtual ICollection<SlashCommands> SlashCommands { get; set; }
        public virtual ICollection<SlaveInteractionSkills> SlaveInteractionSkills { get; set; }
        public virtual ICollection<SphereDoodadInteracts> SphereDoodadInteracts { get; set; }
        public virtual ICollection<SphereSkills> SphereSkills { get; set; }
        public virtual ICollection<TaggedSkills> TaggedSkills { get; set; }
        public virtual ICollection<TooltipSkillEffects> TooltipSkillEffects { get; set; }
    }
}
