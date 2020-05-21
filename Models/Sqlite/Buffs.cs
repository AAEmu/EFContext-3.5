using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class Buffs
    {
        public Buffs()
        {
            Appellations = new HashSet<Appellations>();
            ArmorGradeBuffs = new HashSet<ArmorGradeBuffs>();
            BattleFieldHonorBuffs = new HashSet<BattleFieldHonorBuffs>();
            BattleFieldPickBuffs = new HashSet<BattleFieldPickBuffs>();
            BuffEffects = new HashSet<BuffEffects>();
            BuffModifiers = new HashSet<BuffModifiers>();
            BuffMountSkills = new HashSet<BuffMountSkills>();
            BuffPassiveBuffs = new HashSet<BuffPassiveBuffs>();
            BuffSkills = new HashSet<BuffSkills>();
            BuffSwapSkills = new HashSet<BuffSwapSkills>();
            BuffTickEffects = new HashSet<BuffTickEffects>();
            BuffTriggers = new HashSet<BuffTriggers>();
            BuffUnitModifiers = new HashSet<BuffUnitModifiers>();
            ChangeEquipmentBuffs = new HashSet<ChangeEquipmentBuffs>();
            DoodadFuncBuffs = new HashSet<DoodadFuncBuffs>();
            DoodadFuncClouts = new HashSet<DoodadFuncClouts>();
            DynamicUnitModifiers = new HashSet<DynamicUnitModifiers>();
            EquipItemSetBonuses = new HashSet<EquipItemSetBonuses>();
            ExpeditionLevelBuffs = new HashSet<ExpeditionLevelBuffs>();
            FamilyLevels = new HashSet<FamilyLevels>();
            GuardTowerSteps = new HashSet<GuardTowerSteps>();
            InstrumentSounds = new HashSet<InstrumentSounds>();
            ItemGradeBuffs = new HashSet<ItemGradeBuffs>();
            Items = new HashSet<ItemTemplate>();
            ModelMutations = new HashSet<ModelMutations>();
            NpcInitialBuffs = new HashSet<NpcInitialBuffs>();
            NpcNickBuffs = new HashSet<NpcNickBuffs>();
            PassiveBuffs = new HashSet<PassiveBuffs>();
            PcbangBuffs = new HashSet<PcbangBuffs>();
            PeriodBuffs = new HashSet<PeriodBuffs>();
            PriestBuffs = new HashSet<PriestBuffs>();
            QuestActCheckTimers = new HashSet<QuestActCheckTimers>();
            QuestActConAcceptBuffs = new HashSet<QuestActConAcceptBuffs>();
            QuestActObjInviteTeamFactions = new HashSet<QuestActObjInviteTeamFactions>();
            QuestComponents = new HashSet<QuestComponents>();
            SkillReqs = new HashSet<SkillReqs>();
            SlaveInitialBuffs = new HashSet<SlaveInitialBuffs>();
            SphereBuffs = new HashSet<SphereBuffs>();
            TaggedBuffs = new HashSet<TaggedBuffs>();
            TaggedImmuneBuffs = new HashSet<TaggedImmuneBuffs>();
            TaggedRequireBuffs = new HashSet<TaggedRequireBuffs>();
            ZoneGroups = new HashSet<ZoneGroups>();
        }

        public long Id { get; set; }
        public long? ActiveWeaponId { get; set; }
        public long? AddDurationBuffMul { get; set; }
        public long? AddDurationBuffId { get; set; }
        public string AgStance { get; set; }
        public long? AnimActionId { get; set; }
        public long? AnimEndId { get; set; }
        public long? AnimStartId { get; set; }
        public byte[] AntiStealth { get; set; }
        public byte[] AuraChildOnly { get; set; }
        public byte[] AuraCreatorOnly { get; set; }
        public long? AuraRadius { get; set; }
        public long? AuraRelationId { get; set; }
        public long? AuraSlaveBuffId { get; set; }
        public long? BalanceLevel { get; set; }
        public byte[] BlankMinded { get; set; }
        public double? BossTelescopeRange { get; set; }
        public byte[] CannotJump { get; set; }
        public byte[] CombatTextEnd { get; set; }
        public byte[] CombatTextStart { get; set; }
        public byte[] ConditionalTick { get; set; }
        public long? CooldownSkillId { get; set; }
        public long? CooldownSkillTime { get; set; }
        public byte[] Crippled { get; set; }
        public long? CrowdBuffId { get; set; }
        public byte[] CrowdFriendly { get; set; }
        public byte[] CrowdHostile { get; set; }
        public long? CrowdNumber { get; set; }
        public double? CrowdRadius { get; set; }
        public double? CustomDualMaterialFadeTime { get; set; }
        public long? CustomDualMaterialId { get; set; }
        public long? DamageAbsorptionPerHit { get; set; }
        public long? DamageAbsorptionTypeId { get; set; }
        public byte[] DeadApplicable { get; set; }
        public string Desc { get; set; }
        public byte[] DetectStealth { get; set; }
        public byte[] DisarmamentMainHand { get; set; }
        public byte[] DisarmamentMusical { get; set; }
        public byte[] DisarmamentOffHand { get; set; }
        public byte[] DisarmamentRanged { get; set; }
        public byte[] DoNotRemoveByOtherSkillController { get; set; }
        public long? Duration { get; set; }
        public byte[] EvadeTelescope { get; set; }
        public byte[] Exempt { get; set; }
        public string ExtraEffects { get; set; }
        public long? FactionId { get; set; }
        public byte[] FallDamageImmortality { get; set; }
        public byte[] FallDamageImmune { get; set; }
        public byte[] Fastened { get; set; }
        public double? FindSchoolOfFishRange { get; set; }
        public byte[] FixAbilityLevelToOne { get; set; }
        public byte[] Framehold { get; set; }
        public byte[] FreezeShip { get; set; }
        public long? FxGroupId { get; set; }
        public byte[] Gliding { get; set; }
        public double? GlidingFallSpeedFast { get; set; }
        public double? GlidingFallSpeedNormal { get; set; }
        public double? GlidingFallSpeedSlow { get; set; }
        public double? GlidingLandHeight { get; set; }
        public long? GlidingLiftCount { get; set; }
        public double? GlidingLiftDuration { get; set; }
        public double? GlidingLiftHeight { get; set; }
        public double? GlidingLiftSpeed { get; set; }
        public double? GlidingLiftValidTime { get; set; }
        public double? GlidingMoveSpeedFast { get; set; }
        public double? GlidingMoveSpeedNormal { get; set; }
        public double? GlidingMoveSpeedSlow { get; set; }
        public long? GlidingRotateSpeed { get; set; }
        public double? GlidingSlidingTime { get; set; }
        public double? GlidingSmoothTime { get; set; }
        public double? GlidingStartupSpeed { get; set; }
        public double? GlidingStartupTime { get; set; }
        public long? GroupId { get; set; }
        public long? GroupRank { get; set; }
        public long? IconId { get; set; }
        public string IdleAnim { get; set; }
        public long? ImmuneDamage { get; set; }
        public byte[] ImmuneExceptCreator { get; set; }
        public long? ImmuneExceptCreatorRelationId { get; set; }
        public byte[] ImmuneExceptCreatorRelationCheck { get; set; }
        public long? ImmuneExceptSkillTagId { get; set; }
        public double? ImmuneHealth { get; set; }
        public byte[] ImpossibleChangeTargeting { get; set; }
        public byte[] ImpossibleTargeting { get; set; }
        public long? InitMaxCharge { get; set; }
        public long? InitMinCharge { get; set; }
        public long? KindId { get; set; }
        public byte[] KnockDown { get; set; }
        public byte[] KnockbackImmune { get; set; }
        public long? LevelDuration { get; set; }
        public long? LinkBuffId { get; set; }
        public long? MainhandToolId { get; set; }
        public byte[] ManaBurnImmune { get; set; }
        public long? ManaShieldRatio { get; set; }
        public long? MaxCharge { get; set; }
        public long? MaxHighAbilityResource { get; set; }
        public long? MaxLifeTime { get; set; }
        public long? MaxStack { get; set; }
        public byte[] MeleeImmortality { get; set; }
        public byte[] MeleeImmune { get; set; }
        public long? MinHighAbilityResource { get; set; }
        public string Name { get; set; }
        public byte[] NoCollide { get; set; }
        public byte[] NoCollideRigid { get; set; }
        public byte[] NoExpPenalty { get; set; }
        public byte[] NonPushable { get; set; }
        public byte[] NotToSlaveRider { get; set; }
        public byte[] OffPassive { get; set; }
        public long? OffPassiveExectionTagId { get; set; }
        public long? OffhandToolId { get; set; }
        public byte[] OneTime { get; set; }
        public byte[] OneTimeImmortality { get; set; }
        public byte[] OnlyMyPet { get; set; }
        public byte[] OnlyPetOwner { get; set; }
        public byte[] OwnerOnly { get; set; }
        public byte[] Pacifist { get; set; }
        public byte[] PerUnitCreation { get; set; }
        public long? PercussionInstrumentStartAnimId { get; set; }
        public long? PercussionInstrumentTickAnimId { get; set; }
        public byte[] Psychokinesis { get; set; }
        public double? PsychokinesisSpeed { get; set; }
        public byte[] Ragdoll { get; set; }
        public byte[] RangedImmortality { get; set; }
        public byte[] RangedImmune { get; set; }
        public byte[] RealTime { get; set; }
        public long? ReflectionChance { get; set; }
        public long? ReflectionRatio { get; set; }
        public long? ReflectionTargetRatio { get; set; }
        public long? ReflectionTypeId { get; set; }
        public byte[] RemoveOnAttackBuffTrigger { get; set; }
        public byte[] RemoveOnAttackEtc { get; set; }
        public byte[] RemoveOnAttackEtcDot { get; set; }
        public byte[] RemoveOnAttackSpellDot { get; set; }
        public byte[] RemoveOnAttackedBuffTrigger { get; set; }
        public byte[] RemoveOnAttackedEtc { get; set; }
        public byte[] RemoveOnAttackedEtcDot { get; set; }
        public byte[] RemoveOnAttackedSpellDot { get; set; }
        public byte[] RemoveOnAutoattack { get; set; }
        public byte[] RemoveOnDamageBuffTrigger { get; set; }
        public byte[] RemoveOnDamageEtc { get; set; }
        public byte[] RemoveOnDamageEtcDot { get; set; }
        public byte[] RemoveOnDamageSpellDot { get; set; }
        public byte[] RemoveOnDamagedBuffTrigger { get; set; }
        public byte[] RemoveOnDamagedEtc { get; set; }
        public byte[] RemoveOnDamagedEtcDot { get; set; }
        public byte[] RemoveOnDamagedSpellDot { get; set; }
        public byte[] RemoveOnDeath { get; set; }
        public byte[] RemoveOnExempt { get; set; }
        public byte[] RemoveOnInteraction { get; set; }
        public byte[] RemoveOnLand { get; set; }
        public byte[] RemoveOnMount { get; set; }
        public byte[] RemoveOnMove { get; set; }
        public byte[] RemoveOnSourceDead { get; set; }
        public byte[] RemoveOnStartSkill { get; set; }
        public byte[] RemoveOnUnbond { get; set; }
        public byte[] RemoveOnUnmount { get; set; }
        public long? RemoveOnUnmountAttachPointId { get; set; }
        public byte[] RemoveOnUseSkill { get; set; }
        public long? RequireBuffId { get; set; }
        public byte[] RestrictActionbar { get; set; }
        public long? ResurrectionHealth { get; set; }
        public long? ResurrectionMana { get; set; }
        public byte[] ResurrectionPercent { get; set; }
        public byte[] Root { get; set; }
        public long? SaveRuleId { get; set; }
        public double? Scale { get; set; }
        public double? ScaleDuration { get; set; }
        public byte[] SiegeImmortality { get; set; }
        public byte[] SiegeImmune { get; set; }
        public byte[] Silence { get; set; }
        public long? SkillControllerId { get; set; }
        public byte[] SlaveApplicable { get; set; }
        public byte[] Sleep { get; set; }
        public byte[] SpellImmortality { get; set; }
        public byte[] SpellImmune { get; set; }
        public byte[] SprintMotion { get; set; }
        public long? StackRuleId { get; set; }
        public byte[] Stealth { get; set; }
        public byte[] StopOnlineLpRegen { get; set; }
        public long? StringInstrumentStartAnimId { get; set; }
        public long? StringInstrumentTickAnimId { get; set; }
        public byte[] Stun { get; set; }
        public byte[] System { get; set; }
        public long? TargetingRelationId { get; set; }
        public byte[] TargetingUseOriginSource { get; set; }
        public byte[] Taunt { get; set; }
        public byte[] TauntWithTopAggro { get; set; }
        public double? TelescopeRange { get; set; }
        public long? Tick { get; set; }
        public long? TickActiveWeaponId { get; set; }
        public long? TickAnimId { get; set; }
        public long? TickAreaAngle { get; set; }
        public byte[] TickAreaExcludeSource { get; set; }
        public long? TickAreaFrontAngle { get; set; }
        public double? TickAreaRadius { get; set; }
        public long? TickAreaRelationId { get; set; }
        public byte[] TickAreaUseOriginSource { get; set; }
        public double? TickLevelManaCost { get; set; }
        public long? TickMainhandToolId { get; set; }
        public long? TickManaCost { get; set; }
        public long? TickOffhandToolId { get; set; }
        public double? TransferTelescopeRange { get; set; }
        public long? TransformBuffId { get; set; }
        public long? TubeInstrumentStartAnimId { get; set; }
        public long? TubeInstrumentTickAnimId { get; set; }
        public byte[] UseSourceFaction { get; set; }
        public byte[] WalkOnly { get; set; }

        public virtual AnimActions AnimAction { get; set; }
        public virtual CustomDualMaterials CustomDualMaterial { get; set; }
        public virtual FxGroups FxGroup { get; set; }
        public virtual Icons Icon { get; set; }
        public virtual SkillControllers SkillController { get; set; }
        public virtual ICollection<Appellations> Appellations { get; set; }
        public virtual ICollection<ArmorGradeBuffs> ArmorGradeBuffs { get; set; }
        public virtual ICollection<BattleFieldHonorBuffs> BattleFieldHonorBuffs { get; set; }
        public virtual ICollection<BattleFieldPickBuffs> BattleFieldPickBuffs { get; set; }
        public virtual ICollection<BuffEffects> BuffEffects { get; set; }
        public virtual ICollection<BuffModifiers> BuffModifiers { get; set; }
        public virtual ICollection<BuffMountSkills> BuffMountSkills { get; set; }
        public virtual ICollection<BuffPassiveBuffs> BuffPassiveBuffs { get; set; }
        public virtual ICollection<BuffSkills> BuffSkills { get; set; }
        public virtual ICollection<BuffSwapSkills> BuffSwapSkills { get; set; }
        public virtual ICollection<BuffTickEffects> BuffTickEffects { get; set; }
        public virtual ICollection<BuffTriggers> BuffTriggers { get; set; }
        public virtual ICollection<BuffUnitModifiers> BuffUnitModifiers { get; set; }
        public virtual ICollection<ChangeEquipmentBuffs> ChangeEquipmentBuffs { get; set; }
        public virtual ICollection<DoodadFuncBuffs> DoodadFuncBuffs { get; set; }
        public virtual ICollection<DoodadFuncClouts> DoodadFuncClouts { get; set; }
        public virtual ICollection<DynamicUnitModifiers> DynamicUnitModifiers { get; set; }
        public virtual ICollection<EquipItemSetBonuses> EquipItemSetBonuses { get; set; }
        public virtual ICollection<ExpeditionLevelBuffs> ExpeditionLevelBuffs { get; set; }
        public virtual ICollection<FamilyLevels> FamilyLevels { get; set; }
        public virtual ICollection<GuardTowerSteps> GuardTowerSteps { get; set; }
        public virtual ICollection<InstrumentSounds> InstrumentSounds { get; set; }
        public virtual ICollection<ItemGradeBuffs> ItemGradeBuffs { get; set; }
        public virtual ICollection<ItemTemplate> Items { get; set; }
        public virtual ICollection<ModelMutations> ModelMutations { get; set; }
        public virtual ICollection<NpcInitialBuffs> NpcInitialBuffs { get; set; }
        public virtual ICollection<NpcNickBuffs> NpcNickBuffs { get; set; }
        public virtual ICollection<PassiveBuffs> PassiveBuffs { get; set; }
        public virtual ICollection<PcbangBuffs> PcbangBuffs { get; set; }
        public virtual ICollection<PeriodBuffs> PeriodBuffs { get; set; }
        public virtual ICollection<PriestBuffs> PriestBuffs { get; set; }
        public virtual ICollection<QuestActCheckTimers> QuestActCheckTimers { get; set; }
        public virtual ICollection<QuestActConAcceptBuffs> QuestActConAcceptBuffs { get; set; }
        public virtual ICollection<QuestActObjInviteTeamFactions> QuestActObjInviteTeamFactions { get; set; }
        public virtual ICollection<QuestComponents> QuestComponents { get; set; }
        public virtual ICollection<SkillReqs> SkillReqs { get; set; }
        public virtual ICollection<SlaveInitialBuffs> SlaveInitialBuffs { get; set; }
        public virtual ICollection<SphereBuffs> SphereBuffs { get; set; }
        public virtual ICollection<TaggedBuffs> TaggedBuffs { get; set; }
        public virtual ICollection<TaggedImmuneBuffs> TaggedImmuneBuffs { get; set; }
        public virtual ICollection<TaggedRequireBuffs> TaggedRequireBuffs { get; set; }
        public virtual ICollection<ZoneGroups> ZoneGroups { get; set; }
    }
}
