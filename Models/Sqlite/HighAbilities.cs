namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class HighAbilities
    {
        public long Id { get; set; }
        public long? AbilityId { get; set; }
        public long? HighAbilityId { get; set; }
        public long? HighAbilityResourceRegen { get; set; }
        public long? MaxHighAbilityResource { get; set; }
        public string Name { get; set; }
        public byte[] OrUnitReqs { get; set; }
        public long? PersistentHighAbilityResourceRegen { get; set; }
    }
}
