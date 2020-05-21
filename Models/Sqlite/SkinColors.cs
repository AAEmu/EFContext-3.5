using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class SkinColors
    {
        public SkinColors()
        {
            TotalCharacterCustoms = new HashSet<TotalCharacterCustoms>();
        }

        public long Id { get; set; }
        public long? BrightSkinColorR { get; set; }
        public long? BrightSkinColorG { get; set; }
        public long? BrightSkinColorB { get; set; }
        public string Comment { get; set; }
        public string CustomPostfix { get; set; }
        public long? DiffuseColorR { get; set; }
        public long? DiffuseColorG { get; set; }
        public long? DiffuseColorB { get; set; }
        public long? DisplayOrder { get; set; }
        public long? Glossness { get; set; }
        public string IconPath { get; set; }
        public long? MiddleSkinColorR { get; set; }
        public long? MiddleSkinColorG { get; set; }
        public long? MiddleSkinColorB { get; set; }
        public long? ModelId { get; set; }
        public byte[] NpcOnly { get; set; }
        public long? SpecularColorR { get; set; }
        public long? SpecularColorG { get; set; }
        public long? SpecularColorB { get; set; }
        public double? SpecularLevel { get; set; }

        public virtual Models Model { get; set; }
        public virtual ICollection<TotalCharacterCustoms> TotalCharacterCustoms { get; set; }
    }
}
