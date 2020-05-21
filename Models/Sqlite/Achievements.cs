using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class Achievements
    {
        public Achievements()
        {
            AchievementObjectives = new HashSet<AchievementObjectives>();
        }

        public long Id { get; set; }
        public long? CategoryId { get; set; }
        public long? CompleteNum { get; set; }
        public byte[] CompleteOr { get; set; }
        public string Description { get; set; }
        public long? GradeId { get; set; }
        public long? IconId { get; set; }
        public byte[] IsActive { get; set; }
        public byte[] IsHidden { get; set; }
        public long? ItemNum { get; set; }
        public long? ItemId { get; set; }
        public string Name { get; set; }
        public byte[] OrUnitReqs { get; set; }
        public long? ParentAchievementId { get; set; }
        public long? Priority { get; set; }
        public long? SubCategoryId { get; set; }
        public string Summary { get; set; }

        public virtual Icons Icon { get; set; }
        public virtual ItemTemplate Item { get; set; }
        public virtual ICollection<AchievementObjectives> AchievementObjectives { get; set; }
    }
}
