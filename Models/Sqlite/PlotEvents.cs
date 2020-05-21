namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class PlotEvents
    {
        public long Id { get; set; }
        public byte[] AoeDiminishing { get; set; }
        public string Name { get; set; }
        public byte[] OnlyDieUnit { get; set; }
        public byte[] OnlyMyPet { get; set; }
        public byte[] OnlyMySlave { get; set; }
        public byte[] OnlyPetOwner { get; set; }
        public long? PlotId { get; set; }
        public long? Position { get; set; }
        public long? SourceUpdateMethodId { get; set; }
        public long? TargetUpdateMethodId { get; set; }
        public long? TargetUpdateMethodParam1 { get; set; }
        public long? TargetUpdateMethodParam10 { get; set; }
        public long? TargetUpdateMethodParam11 { get; set; }
        public long? TargetUpdateMethodParam2 { get; set; }
        public long? TargetUpdateMethodParam3 { get; set; }
        public long? TargetUpdateMethodParam4 { get; set; }
        public long? TargetUpdateMethodParam5 { get; set; }
        public long? TargetUpdateMethodParam6 { get; set; }
        public long? TargetUpdateMethodParam7 { get; set; }
        public long? TargetUpdateMethodParam8 { get; set; }
        public long? TargetUpdateMethodParam9 { get; set; }
        public long? Tickets { get; set; }

        public virtual Plots Plot { get; set; }
    }
}
