namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class CharacterEquipPacks
    {
        public long Id { get; set; }
        public long? AbilityId { get; set; }
        public long? NewbieClothPackId { get; set; }
        public long? NewbieWeaponPackId { get; set; }
        
        public virtual EquipPackCloths NewbieClothPack { get; set; }
        public virtual EquipPackWeapons NewbieWeaponPack { get; set; }
    }
}
