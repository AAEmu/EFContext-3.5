namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class SpecialtyNpcs
    {
        public long? NpcId { get; set; }
        public long? SpecialtyBundleId { get; set; }

        public virtual Npcs Npc { get; set; }
        public virtual SpecialtyBundles SpecialtyBundle { get; set; }
    }
}
