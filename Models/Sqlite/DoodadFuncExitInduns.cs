namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class DoodadFuncExitInduns
    {
        public long Id { get; set; }
        public long? ReturnPointId { get; set; }

        public virtual ReturnPoints ReturnPoint { get; set; }
    }
}
