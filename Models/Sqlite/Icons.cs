using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class Icons
    {
        public Icons()
        {
            Achievements = new HashSet<Achievements>();
            Buffs = new HashSet<Buffs>();
            CharacterPreviewCloths = new HashSet<CharacterPreviewCloths>();
            FamilyRoles = new HashSet<FamilyRoles>();
            ItemGrades = new HashSet<ItemGrades>();
            ItemGuideIcons = new HashSet<ItemGuideIcons>();
            Items = new HashSet<ItemTemplate>();
            PremiumBenefits = new HashSet<PremiumBenefits>();
            Skills = new HashSet<Skills>();
            TodayQuestSteps = new HashSet<TodayQuestSteps>();
            TradegoodMaterials = new HashSet<TradegoodMaterials>();
        }

        public long Id { get; set; }
        public string Filename { get; set; }

        public virtual ICollection<Achievements> Achievements { get; set; }
        public virtual ICollection<Buffs> Buffs { get; set; }
        public virtual ICollection<CharacterPreviewCloths> CharacterPreviewCloths { get; set; }
        public virtual ICollection<FamilyRoles> FamilyRoles { get; set; }
        public virtual ICollection<ItemGrades> ItemGrades { get; set; }
        public virtual ICollection<ItemGuideIcons> ItemGuideIcons { get; set; }
        public virtual ICollection<ItemTemplate> Items { get; set; }
        public virtual ICollection<PremiumBenefits> PremiumBenefits { get; set; }
        public virtual ICollection<Skills> Skills { get; set; }
        public virtual ICollection<TodayQuestSteps> TodayQuestSteps { get; set; }
        public virtual ICollection<TradegoodMaterials> TradegoodMaterials { get; set; }
    }
}
