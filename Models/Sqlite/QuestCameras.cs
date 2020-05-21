using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class QuestCameras
    {
        public QuestCameras()
        {
            ModelQuestCameras = new HashSet<ModelQuestCameras>();
        }

        public long Id { get; set; }
        public double? CameraOffsetX { get; set; }
        public double? CameraOffsetY { get; set; }
        public double? CameraOffsetZ { get; set; }
        public string Comment { get; set; }
        public byte[] Dof { get; set; }
        public double? Fov { get; set; }
        public byte[] Interpolate { get; set; }
        public byte[] Invisible { get; set; }
        public double? NpcOffsetX { get; set; }
        public double? NpcOffsetY { get; set; }
        public double? NpcOffsetZ { get; set; }
        public double? NvBokehSize { get; set; }
        public byte[] NvDof { get; set; }
        public double? NvIntensity { get; set; }
        public double? NvLuminance { get; set; }

        public virtual ICollection<ModelQuestCameras> ModelQuestCameras { get; set; }
    }
}
