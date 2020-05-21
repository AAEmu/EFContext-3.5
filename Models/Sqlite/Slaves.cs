using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class Slaves
    {
        public Slaves()
        {
            AllowToEquipSlaves = new HashSet<AllowToEquipSlaves>();
            BattleFieldShips = new HashSet<BattleFieldShips>();
            ItemSlaveEquipmentGradeSpawns = new HashSet<ItemSlaveEquipmentGradeSpawns>();
            ItemSlaveEquipments = new HashSet<ItemSlaveEquipments>();
            ItemSummonSlaves = new HashSet<ItemSummonSlaves>();
            SlaveBindings = new HashSet<SlaveBindings>();
            SlaveEquipSlots = new HashSet<SlaveEquipSlots>();
            SlaveInitialBuffs = new HashSet<SlaveInitialBuffs>();
            SlaveInteractionSkills = new HashSet<SlaveInteractionSkills>();
            SlaveMountSkills = new HashSet<SlaveMountSkills>();
        }

        public long Id { get; set; }
        public double? AddedShipMassPerUnit { get; set; }
        public byte[] CannotRideBackpacker { get; set; }
        public long? Capacity { get; set; }
        public long? Cost { get; set; }
        public byte[] Customizable { get; set; }
        public long? DestroyRate { get; set; }
        public byte[] DriverPosInteraction { get; set; }
        public long? FactionId { get; set; }
        public long? Hp25DoodadCount { get; set; }
        public long? Hp50DoodadCount { get; set; }
        public long? Hp75DoodadCount { get; set; }
        public long? Hp99DoodadCount { get; set; }
        public byte[] IconVisible { get; set; }
        public byte[] IgnoreParentDestroyRate { get; set; }
        public long? Level { get; set; }
        public long? ModelId { get; set; }
        public byte[] Mountable { get; set; }
        public string Name { get; set; }
        public double? ObbPosX { get; set; }
        public double? ObbPosY { get; set; }
        public double? ObbPosZ { get; set; }
        public double? ObbSizeX { get; set; }
        public double? ObbSizeY { get; set; }
        public double? ObbSizeZ { get; set; }
        public double? OffsetX { get; set; }
        public double? OffsetY { get; set; }
        public double? OffsetZ { get; set; }
        public byte[] OnBindUnhangDirectly { get; set; }
        public long? PortalDespawnFxId { get; set; }
        public double? PortalScale { get; set; }
        public long? PortalSpawnFxId { get; set; }
        public double? PortalTime { get; set; }
        public byte[] Respawn { get; set; }
        public long? SinkingCapacity { get; set; }
        public long? SlaveCollisionDamageId { get; set; }
        public long? SlaveCustomizingId { get; set; }
        public long? SlaveEquipmentCategoryId { get; set; }
        public long? SlaveInitialItemPackId { get; set; }
        public long? SlaveKindId { get; set; }
        public long? SpawnValidAreaRange { get; set; }
        public double? SpawnXOffset { get; set; }
        public double? SpawnYOffset { get; set; }

        public virtual Models Model { get; set; }
        public virtual SlaveCollisionDamages SlaveCollisionDamage { get; set; }
        public virtual SlaveCustomizings SlaveCustomizing { get; set; }
        public virtual SlaveInitialItemPacks SlaveInitialItemPack { get; set; }
        public virtual ICollection<AllowToEquipSlaves> AllowToEquipSlaves { get; set; }
        public virtual ICollection<BattleFieldShips> BattleFieldShips { get; set; }
        public virtual ICollection<ItemSlaveEquipmentGradeSpawns> ItemSlaveEquipmentGradeSpawns { get; set; }
        public virtual ICollection<ItemSlaveEquipments> ItemSlaveEquipments { get; set; }
        public virtual ICollection<ItemSummonSlaves> ItemSummonSlaves { get; set; }
        public virtual ICollection<SlaveBindings> SlaveBindings { get; set; }
        public virtual ICollection<SlaveEquipSlots> SlaveEquipSlots { get; set; }
        public virtual ICollection<SlaveInitialBuffs> SlaveInitialBuffs { get; set; }
        public virtual ICollection<SlaveInteractionSkills> SlaveInteractionSkills { get; set; }
        public virtual ICollection<SlaveMountSkills> SlaveMountSkills { get; set; }
    }
}
