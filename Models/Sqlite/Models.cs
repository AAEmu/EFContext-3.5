using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class Models
    {
        public Models()
        {
            BodyDiffuseMaps = new HashSet<BodyDiffuseMaps>();
            BodyNormalMaps = new HashSet<BodyNormalMaps>();
            Characters = new HashSet<Characters>();
            CustomFacePresets = new HashSet<CustomFacePresets>();
            CustomizingItemAssetColors = new HashSet<CustomizingItemAssetColors>();
            CustomizingItemAssets = new HashSet<CustomizingItemAssets>();
            FaceDecalAssets = new HashSet<FaceDecalAssets>();
            FaceNormalMaps = new HashSet<FaceNormalMaps>();
            HandIkOffsets = new HashSet<HandIkOffsets>();
            HousingBuildSteps = new HashSet<HousingBuildSteps>();
            ItemAssets = new HashSet<ItemAssets>();
            ItemBodyParts = new HashSet<ItemBodyParts>();
            ModelQuestCameras = new HashSet<ModelQuestCameras>();
            Npcs = new HashSet<Npcs>();
            ShipyardSteps = new HashSet<ShipyardSteps>();
            SkinColors = new HashSet<SkinColors>();
            Slaves = new HashSet<Slaves>();
            TotalCharacterCustoms = new HashSet<TotalCharacterCustoms>();
            Transfers = new HashSet<Transfers>();
        }

        public long Id { get; set; }
        public byte[] Big { get; set; }
        public double? CameraDistance { get; set; }
        public double? CameraDistanceForWideAngle { get; set; }
        public byte[] DespawnDoodadOnCollision { get; set; }
        public double? DyingTime { get; set; }
        public long? HighImpactFxGroupId { get; set; }
        public long? LowImpactFxGroupId { get; set; }
        public long? MiddleImpactFxGroupId { get; set; }
        public long? MountPoseId { get; set; }
        public string Name { get; set; }
        public double? NameTagOffset { get; set; }
        public byte[] PlayMountAnimation { get; set; }
        public byte[] PlayerMountNameTagPos { get; set; }
        public byte[] Selectable { get; set; }
        public byte[] ShowNameTag { get; set; }
        public long? SoundMaterialId { get; set; }
        public long? SoundPackId { get; set; }
        public string SubType { get; set; }
        public long? SubId { get; set; }
        public double? TargetDecalSize { get; set; }
        public byte[] UseTargetDecal { get; set; }
        public byte[] UseTargetHighlight { get; set; }
        public byte[] UseTargetSilhouette { get; set; }

        public virtual MountPoses MountPose { get; set; }
        public virtual SoundPacks SoundPack { get; set; }
        public virtual ICollection<BodyDiffuseMaps> BodyDiffuseMaps { get; set; }
        public virtual ICollection<BodyNormalMaps> BodyNormalMaps { get; set; }
        public virtual ICollection<Characters> Characters { get; set; }
        public virtual ICollection<CustomFacePresets> CustomFacePresets { get; set; }
        public virtual ICollection<CustomizingItemAssetColors> CustomizingItemAssetColors { get; set; }
        public virtual ICollection<CustomizingItemAssets> CustomizingItemAssets { get; set; }
        public virtual ICollection<FaceDecalAssets> FaceDecalAssets { get; set; }
        public virtual ICollection<FaceNormalMaps> FaceNormalMaps { get; set; }
        public virtual ICollection<HandIkOffsets> HandIkOffsets { get; set; }
        public virtual ICollection<HousingBuildSteps> HousingBuildSteps { get; set; }
        public virtual ICollection<ItemAssets> ItemAssets { get; set; }
        public virtual ICollection<ItemBodyParts> ItemBodyParts { get; set; }
        public virtual ICollection<ModelQuestCameras> ModelQuestCameras { get; set; }
        public virtual ICollection<Npcs> Npcs { get; set; }
        public virtual ICollection<ShipyardSteps> ShipyardSteps { get; set; }
        public virtual ICollection<SkinColors> SkinColors { get; set; }
        public virtual ICollection<Slaves> Slaves { get; set; }
        public virtual ICollection<TotalCharacterCustoms> TotalCharacterCustoms { get; set; }
        public virtual ICollection<Transfers> Transfers { get; set; }
    }
}
