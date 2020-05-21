using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ItemTemplate
    {
        public ItemTemplate()
        {
            AccountAttendanceRewards = new HashSet<AccountAttendanceRewards>();
            Achievements = new HashSet<Achievements>();
            BagExpands = new HashSet<BagExpands>();
            BattleFieldRewards = new HashSet<BattleFieldRewards>();
            BattleFieldShipEquipments = new HashSet<BattleFieldShipEquipments>();
            BattleFields = new HashSet<BattleFields>();
            CharacterSupplies = new HashSet<CharacterSupplies>();
            CraftMaterials = new HashSet<CraftMaterials>();
            CraftProducts = new HashSet<CraftProducts>();
            CustomizingItemAssets = new HashSet<CustomizingItemAssets>();
            DoodadFuncBuyFishItems = new HashSet<DoodadFuncBuyFishItems>();
            DoodadFuncBuyFishModelItems = new HashSet<DoodadFuncBuyFishModelItems>();
            DoodadFuncBuyFishes = new HashSet<DoodadFuncBuyFishes>();
            DoodadFuncConditionalUses = new HashSet<DoodadFuncConditionalUses>();
            DoodadFuncConsumeItems = new HashSet<DoodadFuncConsumeItems>();
            DoodadFuncConvertFishItems = new HashSet<DoodadFuncConvertFishItems>();
            DoodadFuncDevotes = new HashSet<DoodadFuncDevotes>();
            DoodadFuncDominionTaxInKinds = new HashSet<DoodadFuncDominionTaxInKinds>();
            DoodadFuncEnterInstances = new HashSet<DoodadFuncEnterInstances>();
            DoodadFuncExchangeItems = new HashSet<DoodadFuncExchangeItems>();
            DoodadFuncFeeds = new HashSet<DoodadFuncFeeds>();
            DoodadFuncInsertCounters = new HashSet<DoodadFuncInsertCounters>();
            DoodadFuncItemChangers = new HashSet<DoodadFuncItemChangers>();
            DoodadFuncLootItems = new HashSet<DoodadFuncLootItems>();
            DoodadFuncPurchases = new HashSet<DoodadFuncPurchases>();
            DoodadFuncPuzzleRolls = new HashSet<DoodadFuncPuzzleRolls>();
            DoodadFuncRemoveItems = new HashSet<DoodadFuncRemoveItems>();
            DoodadFuncRequireItems = new HashSet<DoodadFuncRequireItems>();
            DoodadFuncStampMakers = new HashSet<DoodadFuncStampMakers>();
            DyeableItems = new HashSet<DyeableItems>();
            ExpandExpertLimits = new HashSet<ExpandExpertLimits>();
            ExpeditionLevelReqs = new HashSet<ExpeditionLevelReqs>();
            FaceDecalAssets = new HashSet<FaceDecalAssets>();
            FamilyMemberLimits = new HashSet<FamilyMemberLimits>();
            FarmGroupDoodads = new HashSet<FarmGroupDoodads>();
            FishDetails = new HashSet<FishDetails>();
            GachaLootPackItems = new HashSet<GachaLootPackItems>();
            HeroBonuses = new HashSet<HeroBonuses>();
            HeroRewards = new HashSet<HeroRewards>();
            HousingRebuildingMaterials = new HashSet<HousingRebuildingMaterials>();
            ImprintUccEffects = new HashSet<ImprintUccEffects>();
            IndestructibleItems = new HashSet<IndestructibleItems>();
            IndunZones = new HashSet<IndunZones>();
            InstrumentSounds = new HashSet<InstrumentSounds>();
            ItemAcceptQuests = new HashSet<ItemAcceptQuests>();
            ItemAccessories = new HashSet<ItemAccessories>();
            ItemArmors = new HashSet<ItemArmors>();
            ItemAssetTransforms = new HashSet<ItemAssetTransforms>();
            ItemBackpacks = new HashSet<ItemBackpacks>();
            ItemBags = new HashSet<ItemBags>();
            ItemBodyParts = new HashSet<ItemBodyParts>();
            ItemCapScaleForbids = new HashSet<ItemCapScaleForbids>();
            ItemConvProducts = new HashSet<ItemConvProducts>();
            ItemConvReagents = new HashSet<ItemConvReagents>();
            ItemDyeings = new HashSet<ItemDyeings>();
            ItemEnchantRatioItems = new HashSet<ItemEnchantRatioItems>();
            ItemEnchantingGems = new HashSet<ItemEnchantingGems>();
            ItemGradeBuffs = new HashSet<ItemGradeBuffs>();
            ItemGradeEnchantingSupports = new HashSet<ItemGradeEnchantingSupports>();
            ItemHousingDecorations = new HashSet<ItemHousingDecorations>();
            ItemHousings = new HashSet<ItemHousings>();
            ItemLookConvertRequiredItems = new HashSet<ItemLookConvertRequiredItems>();
            ItemLookRevertRequiredItems = new HashSet<ItemLookRevertRequiredItems>();
            ItemOpenPapers = new HashSet<ItemOpenPapers>();
            ItemProcBindings = new HashSet<ItemProcBindings>();
            ItemRecipes = new HashSet<ItemRecipes>();
            ItemSecureExceptions = new HashSet<ItemSecureExceptions>();
            ItemSetItems = new HashSet<ItemSetItems>();
            ItemShipyards = new HashSet<ItemShipyards>();
            ItemSlaveEquipmentGradeSpawns = new HashSet<ItemSlaveEquipmentGradeSpawns>();
            ItemSlaveEquipmentSlaveEquipslotPacks = new HashSet<ItemSlaveEquipmentSlaveEquipslotPacks>();
            ItemSlaveEquipments = new HashSet<ItemSlaveEquipments>();
            ItemSmeltingItems = new HashSet<ItemSmeltingItems>();
            ItemSmeltings = new HashSet<ItemSmeltings>();
            ItemSocketLevelLimits = new HashSet<ItemSocketLevelLimits>();
            ItemSockets = new HashSet<ItemSockets>();
            ItemSpawnDoodads = new HashSet<ItemSpawnDoodads>();
            ItemSummonMates = new HashSet<ItemSummonMates>();
            ItemSummonSlaves = new HashSet<ItemSummonSlaves>();
            ItemTools = new HashSet<ItemTools>();
            ItemWeapons = new HashSet<ItemWeapons>();
            MateEquipPacks = new HashSet<MateEquipPacks>();
            MerchantPacks = new HashSet<MerchantPacks>();
            Merchants = new HashSet<Merchants>();
            NationRelations = new HashSet<NationRelations>();
            OpenPortalInlandReagents = new HashSet<OpenPortalInlandReagents>();
            OpenPortalOutlandReagents = new HashSet<OpenPortalOutlandReagents>();
            QuestActConAcceptItemEquips = new HashSet<QuestActConAcceptItemEquips>();
            QuestActConAcceptItemGains = new HashSet<QuestActConAcceptItemGains>();
            QuestActConAcceptItems = new HashSet<QuestActConAcceptItems>();
            QuestActEtcItemObtains = new HashSet<QuestActEtcItemObtains>();
            QuestActObjItemGathers = new HashSet<QuestActObjItemGathers>();
            QuestActObjItemUses = new HashSet<QuestActObjItemUses>();
            QuestActObjMateLevels = new HashSet<QuestActObjMateLevels>();
            QuestActObjTalks = new HashSet<QuestActObjTalks>();
            QuestActSupplyItems = new HashSet<QuestActSupplyItems>();
            QuestActSupplyRankedItems = new HashSet<QuestActSupplyRankedItems>();
            QuestActSupplyRemoveItems = new HashSet<QuestActSupplyRemoveItems>();
            QuestActSupplySelectiveItems = new HashSet<QuestActSupplySelectiveItems>();
            QuestItemGroupItems = new HashSet<QuestItemGroupItems>();
            RankRewards = new HashSet<RankRewards>();
            RankingRewards = new HashSet<RankingRewards>();
            ScheduleItems = new HashSet<ScheduleItems>();
            Shipyards = new HashSet<Shipyards>();
            SkillProducts = new HashSet<SkillProducts>();
            SkillReagents = new HashSet<SkillReagents>();
            SlaveInitialItems = new HashSet<SlaveInitialItems>();
            SpecialtyBundleItems = new HashSet<SpecialtyBundleItems>();
            SpecialtyEventTriggers = new HashSet<SpecialtyEventTriggers>();
            TaggedItems = new HashSet<TaggedItems>();
            TodayQuestGoalItems = new HashSet<TodayQuestGoalItems>();
            TodayQuestSteps = new HashSet<TodayQuestSteps>();
            Tradegoods = new HashSet<Tradegoods>();
        }

        public long Id { get; set; }
        public long? ActabilityGroupId { get; set; }
        public long? ActabilityRequirement { get; set; }
        public long? AuctionACategoryId { get; set; }
        public long? AuctionBCategoryId { get; set; }
        public long? AuctionCCategoryId { get; set; }
        public long? AuctionCharge { get; set; }
        public byte[] AuctionChargeDefault { get; set; }
        public byte[] AutoRegisterToActionbar { get; set; }
        public long? BindId { get; set; }
        public string BuffModifierTooltip { get; set; }
        public long? BuffId { get; set; }
        public byte[] CashItem { get; set; }
        public long? CategoryId { get; set; }
        public long? CharGenderId { get; set; }
        public long? ContributionPointPrice { get; set; }
        public long? CraftId { get; set; }
        public string Description { get; set; }
        public byte[] DisallowCoffer { get; set; }
        public byte[] Disenchantable { get; set; }
        public long? ExpAbsLifetime { get; set; }
        public double? ExpDate { get; set; }
        public long? ExpOnlineLifetime { get; set; }
        public long? ExpeditionLevel { get; set; }
        public long? FixedGrade { get; set; }
        public byte[] Gradable { get; set; }
        public long? HonorPrice { get; set; }
        public long? IconId { get; set; }
        public long? ImplId { get; set; }
        public long? IngameshopMainCategory { get; set; }
        public long? IngameshopSubCategory { get; set; }
        public long? ItemGuideId { get; set; }
        public long? Level { get; set; }
        public long? LevelLimit { get; set; }
        public long? LevelRequirement { get; set; }
        public long? LimitedSaleCount { get; set; }
        public long? LivingPointPrice { get; set; }
        public byte[] LootMulti { get; set; }
        public long? LootQuestId { get; set; }
        public long? MaleIconId { get; set; }
        public long? MaxEnchantableGrade { get; set; }
        public int MaxStackSize { get; set; }
        public string Name { get; set; }
        public byte[] NotifyUi { get; set; }
        public byte[] OneTimeSale { get; set; }
        public long? OverIconId { get; set; }
        public long? PickupLimit { get; set; }
        public long? PickupSoundId { get; set; }
        public long? Price { get; set; }
        public long? Refund { get; set; }
        public byte[] Sellable { get; set; }
        public byte[] SideEffect { get; set; }
        public string SkillModifierTooltip { get; set; }
        public long? SpecialtyZoneId { get; set; }
        public long? UseOrEquipmentSoundId { get; set; }
        public byte[] UseSkillAsReagent { get; set; }
        public long? UseSkillLifetime { get; set; }
        public long? UseSkillRechargeRestrictItemId { get; set; }
        public long? UseSkillId { get; set; }

        public virtual ActabilityGroups ActabilityGroup { get; set; }
        public virtual Buffs Buff { get; set; }
        public virtual Crafts Craft { get; set; }
        public virtual Icons Icon { get; set; }
        public virtual ItemGuides ItemGuide { get; set; }
        public virtual ICollection<AccountAttendanceRewards> AccountAttendanceRewards { get; set; }
        public virtual ICollection<Achievements> Achievements { get; set; }
        public virtual ICollection<BagExpands> BagExpands { get; set; }
        public virtual ICollection<BattleFieldRewards> BattleFieldRewards { get; set; }
        public virtual ICollection<BattleFieldShipEquipments> BattleFieldShipEquipments { get; set; }
        public virtual ICollection<BattleFields> BattleFields { get; set; }
        public virtual ICollection<CharacterSupplies> CharacterSupplies { get; set; }
        public virtual ICollection<CraftMaterials> CraftMaterials { get; set; }
        public virtual ICollection<CraftProducts> CraftProducts { get; set; }
        public virtual ICollection<CustomizingItemAssets> CustomizingItemAssets { get; set; }
        public virtual ICollection<DoodadFuncBuyFishItems> DoodadFuncBuyFishItems { get; set; }
        public virtual ICollection<DoodadFuncBuyFishModelItems> DoodadFuncBuyFishModelItems { get; set; }
        public virtual ICollection<DoodadFuncBuyFishes> DoodadFuncBuyFishes { get; set; }
        public virtual ICollection<DoodadFuncConditionalUses> DoodadFuncConditionalUses { get; set; }
        public virtual ICollection<DoodadFuncConsumeItems> DoodadFuncConsumeItems { get; set; }
        public virtual ICollection<DoodadFuncConvertFishItems> DoodadFuncConvertFishItems { get; set; }
        public virtual ICollection<DoodadFuncDevotes> DoodadFuncDevotes { get; set; }
        public virtual ICollection<DoodadFuncDominionTaxInKinds> DoodadFuncDominionTaxInKinds { get; set; }
        public virtual ICollection<DoodadFuncEnterInstances> DoodadFuncEnterInstances { get; set; }
        public virtual ICollection<DoodadFuncExchangeItems> DoodadFuncExchangeItems { get; set; }
        public virtual ICollection<DoodadFuncFeeds> DoodadFuncFeeds { get; set; }
        public virtual ICollection<DoodadFuncInsertCounters> DoodadFuncInsertCounters { get; set; }
        public virtual ICollection<DoodadFuncItemChangers> DoodadFuncItemChangers { get; set; }
        public virtual ICollection<DoodadFuncLootItems> DoodadFuncLootItems { get; set; }
        public virtual ICollection<DoodadFuncPurchases> DoodadFuncPurchases { get; set; }
        public virtual ICollection<DoodadFuncPuzzleRolls> DoodadFuncPuzzleRolls { get; set; }
        public virtual ICollection<DoodadFuncRemoveItems> DoodadFuncRemoveItems { get; set; }
        public virtual ICollection<DoodadFuncRequireItems> DoodadFuncRequireItems { get; set; }
        public virtual ICollection<DoodadFuncStampMakers> DoodadFuncStampMakers { get; set; }
        public virtual ICollection<DyeableItems> DyeableItems { get; set; }
        public virtual ICollection<ExpandExpertLimits> ExpandExpertLimits { get; set; }
        public virtual ICollection<ExpeditionLevelReqs> ExpeditionLevelReqs { get; set; }
        public virtual ICollection<FaceDecalAssets> FaceDecalAssets { get; set; }
        public virtual ICollection<FamilyMemberLimits> FamilyMemberLimits { get; set; }
        public virtual ICollection<FarmGroupDoodads> FarmGroupDoodads { get; set; }
        public virtual ICollection<FishDetails> FishDetails { get; set; }
        public virtual ICollection<GachaLootPackItems> GachaLootPackItems { get; set; }
        public virtual ICollection<HeroBonuses> HeroBonuses { get; set; }
        public virtual ICollection<HeroRewards> HeroRewards { get; set; }
        public virtual ICollection<HousingRebuildingMaterials> HousingRebuildingMaterials { get; set; }
        public virtual ICollection<ImprintUccEffects> ImprintUccEffects { get; set; }
        public virtual ICollection<IndestructibleItems> IndestructibleItems { get; set; }
        public virtual ICollection<IndunZones> IndunZones { get; set; }
        public virtual ICollection<InstrumentSounds> InstrumentSounds { get; set; }
        public virtual ICollection<ItemAcceptQuests> ItemAcceptQuests { get; set; }
        public virtual ICollection<ItemAccessories> ItemAccessories { get; set; }
        public virtual ICollection<ItemArmors> ItemArmors { get; set; }
        public virtual ICollection<ItemAssetTransforms> ItemAssetTransforms { get; set; }
        public virtual ICollection<ItemBackpacks> ItemBackpacks { get; set; }
        public virtual ICollection<ItemBags> ItemBags { get; set; }
        public virtual ICollection<ItemBodyParts> ItemBodyParts { get; set; }
        public virtual ICollection<ItemCapScaleForbids> ItemCapScaleForbids { get; set; }
        public virtual ICollection<ItemConvProducts> ItemConvProducts { get; set; }
        public virtual ICollection<ItemConvReagents> ItemConvReagents { get; set; }
        public virtual ICollection<ItemDyeings> ItemDyeings { get; set; }
        public virtual ICollection<ItemEnchantRatioItems> ItemEnchantRatioItems { get; set; }
        public virtual ICollection<ItemEnchantingGems> ItemEnchantingGems { get; set; }
        public virtual ICollection<ItemGradeBuffs> ItemGradeBuffs { get; set; }
        public virtual ICollection<ItemGradeEnchantingSupports> ItemGradeEnchantingSupports { get; set; }
        public virtual ICollection<ItemHousingDecorations> ItemHousingDecorations { get; set; }
        public virtual ICollection<ItemHousings> ItemHousings { get; set; }
        public virtual ICollection<ItemLookConvertRequiredItems> ItemLookConvertRequiredItems { get; set; }
        public virtual ICollection<ItemLookRevertRequiredItems> ItemLookRevertRequiredItems { get; set; }
        public virtual ICollection<ItemOpenPapers> ItemOpenPapers { get; set; }
        public virtual ICollection<ItemProcBindings> ItemProcBindings { get; set; }
        public virtual ICollection<ItemRecipes> ItemRecipes { get; set; }
        public virtual ICollection<ItemSecureExceptions> ItemSecureExceptions { get; set; }
        public virtual ICollection<ItemSetItems> ItemSetItems { get; set; }
        public virtual ICollection<ItemShipyards> ItemShipyards { get; set; }
        public virtual ICollection<ItemSlaveEquipmentGradeSpawns> ItemSlaveEquipmentGradeSpawns { get; set; }
        public virtual ICollection<ItemSlaveEquipmentSlaveEquipslotPacks> ItemSlaveEquipmentSlaveEquipslotPacks { get; set; }
        public virtual ICollection<ItemSlaveEquipments> ItemSlaveEquipments { get; set; }
        public virtual ICollection<ItemSmeltingItems> ItemSmeltingItems { get; set; }
        public virtual ICollection<ItemSmeltings> ItemSmeltings { get; set; }
        public virtual ICollection<ItemSocketLevelLimits> ItemSocketLevelLimits { get; set; }
        public virtual ICollection<ItemSockets> ItemSockets { get; set; }
        public virtual ICollection<ItemSpawnDoodads> ItemSpawnDoodads { get; set; }
        public virtual ICollection<ItemSummonMates> ItemSummonMates { get; set; }
        public virtual ICollection<ItemSummonSlaves> ItemSummonSlaves { get; set; }
        public virtual ICollection<ItemTools> ItemTools { get; set; }
        public virtual ICollection<ItemWeapons> ItemWeapons { get; set; }
        public virtual ICollection<MateEquipPacks> MateEquipPacks { get; set; }
        public virtual ICollection<MerchantPacks> MerchantPacks { get; set; }
        public virtual ICollection<Merchants> Merchants { get; set; }
        public virtual ICollection<NationRelations> NationRelations { get; set; }
        public virtual ICollection<OpenPortalInlandReagents> OpenPortalInlandReagents { get; set; }
        public virtual ICollection<OpenPortalOutlandReagents> OpenPortalOutlandReagents { get; set; }
        public virtual ICollection<QuestActConAcceptItemEquips> QuestActConAcceptItemEquips { get; set; }
        public virtual ICollection<QuestActConAcceptItemGains> QuestActConAcceptItemGains { get; set; }
        public virtual ICollection<QuestActConAcceptItems> QuestActConAcceptItems { get; set; }
        public virtual ICollection<QuestActEtcItemObtains> QuestActEtcItemObtains { get; set; }
        public virtual ICollection<QuestActObjItemGathers> QuestActObjItemGathers { get; set; }
        public virtual ICollection<QuestActObjItemUses> QuestActObjItemUses { get; set; }
        public virtual ICollection<QuestActObjMateLevels> QuestActObjMateLevels { get; set; }
        public virtual ICollection<QuestActObjTalks> QuestActObjTalks { get; set; }
        public virtual ICollection<QuestActSupplyItems> QuestActSupplyItems { get; set; }
        public virtual ICollection<QuestActSupplyRankedItems> QuestActSupplyRankedItems { get; set; }
        public virtual ICollection<QuestActSupplyRemoveItems> QuestActSupplyRemoveItems { get; set; }
        public virtual ICollection<QuestActSupplySelectiveItems> QuestActSupplySelectiveItems { get; set; }
        public virtual ICollection<QuestItemGroupItems> QuestItemGroupItems { get; set; }
        public virtual ICollection<RankRewards> RankRewards { get; set; }
        public virtual ICollection<RankingRewards> RankingRewards { get; set; }
        public virtual ICollection<ScheduleItems> ScheduleItems { get; set; }
        public virtual ICollection<Shipyards> Shipyards { get; set; }
        public virtual ICollection<SkillProducts> SkillProducts { get; set; }
        public virtual ICollection<SkillReagents> SkillReagents { get; set; }
        public virtual ICollection<SlaveInitialItems> SlaveInitialItems { get; set; }
        public virtual ICollection<SpecialtyBundleItems> SpecialtyBundleItems { get; set; }
        public virtual ICollection<SpecialtyEventTriggers> SpecialtyEventTriggers { get; set; }
        public virtual ICollection<TaggedItems> TaggedItems { get; set; }
        public virtual ICollection<TodayQuestGoalItems> TodayQuestGoalItems { get; set; }
        public virtual ICollection<TodayQuestSteps> TodayQuestSteps { get; set; }
        public virtual ICollection<Tradegoods> Tradegoods { get; set; }
    }
}
