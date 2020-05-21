namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ShipyardSteps
    {
        public long Id { get; set; }
        public long? MaxHp { get; set; }
        public long? ModelId { get; set; }
        public long? NumActions { get; set; }
        public long? ShipyardId { get; set; }
        public long? SkillId { get; set; }
        public long? Step { get; set; }

        public virtual Models Model { get; set; }
        public virtual Shipyards Shipyard { get; set; }
        public virtual Skills Skill { get; set; }
    }
}
