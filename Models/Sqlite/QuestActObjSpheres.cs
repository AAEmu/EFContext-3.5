namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class QuestActObjSpheres
    {
        public long Id { get; set; }
        public string Cinema { get; set; }
        public long? HighlightDoodadPhase { get; set; }
        public long? HighlightDoodadId { get; set; }
        public string Name { get; set; }
        public long? NpcId { get; set; }
        public long? QuestActObjAliasId { get; set; }
        public long? SphereId { get; set; }
        public byte[] UseAlias { get; set; }

        public virtual Npcs Npc { get; set; }
        public virtual Spheres Sphere { get; set; }
    }
}
