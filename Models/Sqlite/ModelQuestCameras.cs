namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ModelQuestCameras
    {
        public long Id { get; set; }
        public long? ModelId { get; set; }
        public long? QuestCameraId { get; set; }

        public virtual Models Model { get; set; }
        public virtual QuestCameras QuestCamera { get; set; }
    }
}
