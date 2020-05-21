namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ExpressTexts
    {
        public long Id { get; set; }
        public long? AnimId { get; set; }
        public string Me { get; set; }
        public string MeTarget { get; set; }
        public long? NpcAnimId { get; set; }
        public string Other { get; set; }
        public string OtherMe { get; set; }
        public string OtherTarget { get; set; }

        public virtual Anims Anim { get; set; }
    }
}
