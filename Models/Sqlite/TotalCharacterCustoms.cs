namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class TotalCharacterCustoms
    {
        public long Id { get; set; }
        public long? BodyNormalMapId { get; set; }
        public double? BodyNormalMapWeight { get; set; }
        public long? DecoColor { get; set; }
        public long? DefaultHairColor { get; set; }
        public long? DisplayOrder { get; set; }
        public long? EyebrowColor { get; set; }
        public long? FaceDiffuseMapId { get; set; }
        public long? FaceEyelashMapId { get; set; }
        public long? FaceFixedDecalAsset0Id { get; set; }
        public double? FaceFixedDecalAsset0Weight { get; set; }
        public long? FaceFixedDecalAsset1Id { get; set; }
        public double? FaceFixedDecalAsset1Weight { get; set; }
        public long? FaceFixedDecalAsset2Id { get; set; }
        public double? FaceFixedDecalAsset2Weight { get; set; }
        public long? FaceFixedDecalAsset3Id { get; set; }
        public double? FaceFixedDecalAsset3Weight { get; set; }
        public long? FaceFixedDecalAsset4Id { get; set; }
        public double? FaceFixedDecalAsset4Weight { get; set; }
        public long? FaceFixedDecalAsset5Id { get; set; }
        public double? FaceFixedDecalAsset5Weight { get; set; }
        public long? FaceMovableDecalAssetId { get; set; }
        public long? FaceMovableDecalMoveX { get; set; }
        public long? FaceMovableDecalMoveY { get; set; }
        public double? FaceMovableDecalRotate { get; set; }
        public double? FaceMovableDecalScale { get; set; }
        public double? FaceMovableDecalWeight { get; set; }
        public long? FaceNormalMapId { get; set; }
        public double? FaceNormalMapWeight { get; set; }
        public long? HairColorId { get; set; }
        public long? HairId { get; set; }
        public long? HornColorId { get; set; }
        public long? HornId { get; set; }
        public string IconPath { get; set; }
        public long? LeftPupilColor { get; set; }
        public long? LipColor { get; set; }
        public long? ModelId { get; set; }
        public byte[] Modifier { get; set; }
        public string Name { get; set; }
        public byte[] NpcOnly { get; set; }
        public long? OwnerTypeId { get; set; }
        public long? RightPupilColor { get; set; }
        public long? SkinColorId { get; set; }
        public double? TwoToneFirstWidth { get; set; }
        public long? TwoToneHairColor { get; set; }
        public double? TwoToneSecondWidth { get; set; }

        public virtual BodyNormalMaps BodyNormalMap { get; set; }
        public virtual FaceNormalMaps FaceNormalMap { get; set; }
        public virtual Models Model { get; set; }
        public virtual SkinColors SkinColor { get; set; }
    }
}
