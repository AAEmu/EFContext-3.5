namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class BattleFieldShips
    {
        public long Id { get; set; }
        public string Desc { get; set; }
        public byte[] IncPickCountEnable { get; set; }
        public string Name { get; set; }
        public long? NeedBuffId { get; set; }
        public string ShipImg { get; set; }
        public long? SlaveId { get; set; }

        public virtual Slaves Slave { get; set; }
    }
}
