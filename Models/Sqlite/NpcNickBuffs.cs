namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class NpcNickBuffs
    {
        public long? NpcNicknameId { get; set; }
        public long? BuffId { get; set; }

        public virtual Buffs Buff { get; set; }
        public virtual NpcNicknames NpcNickname { get; set; }
    }
}
