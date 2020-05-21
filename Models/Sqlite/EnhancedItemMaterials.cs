using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class EnhancedItemMaterials
    {
        public EnhancedItemMaterials()
        {
            EnhancedItemMaterialArmorDefaults = new HashSet<EnhancedItemMaterialArmorDefaults>();
            EnhancedItemMaterialWeaponDefaults = new HashSet<EnhancedItemMaterialWeaponDefaults>();
            ItemArmors = new HashSet<ItemArmors>();
            ItemWeapons = new HashSet<ItemWeapons>();
        }

        public long Id { get; set; }
        public string Filename { get; set; }

        public virtual ICollection<EnhancedItemMaterialArmorDefaults> EnhancedItemMaterialArmorDefaults { get; set; }
        public virtual ICollection<EnhancedItemMaterialWeaponDefaults> EnhancedItemMaterialWeaponDefaults { get; set; }
        public virtual ICollection<ItemArmors> ItemArmors { get; set; }
        public virtual ICollection<ItemWeapons> ItemWeapons { get; set; }
    }
}
