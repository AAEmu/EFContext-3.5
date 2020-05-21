namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class FlyingStateChangeEffects
    {
        public long Id { get; set; }
        public byte[] FlyingState { get; set; }
    }
}
