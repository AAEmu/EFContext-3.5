namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class FamilyRoles
    {
        public long Id { get; set; }
        public long? IconId { get; set; }
        public long? RoleCount { get; set; }
        public string RoleName { get; set; }

        public virtual Icons Icon { get; set; }
    }
}
