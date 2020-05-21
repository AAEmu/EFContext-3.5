namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class DoodadFuncSpawnMgmts
    {
        public long Id { get; set; }
        public long? GroupId { get; set; }
        public byte[] Spawn { get; set; }
        public long? ZoneId { get; set; }

        public virtual Zones Zone { get; set; }
    }
}
