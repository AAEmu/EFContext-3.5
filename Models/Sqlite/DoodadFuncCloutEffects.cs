namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class DoodadFuncCloutEffects
    {
        public long? DoodadFuncCloutId { get; set; }
        public long? EffectId { get; set; }

        public virtual DoodadFuncClouts DoodadFuncClout { get; set; }
        public virtual Effects Effect { get; set; }
    }
}
