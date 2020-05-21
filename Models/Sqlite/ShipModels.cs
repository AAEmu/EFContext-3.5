namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ShipModels
    {
        public long Id { get; set; }
        public double? Accel { get; set; }
        public double? AccelExponent { get; set; }
        public long? CharAnimSteerBackwardId { get; set; }
        public long? CharAnimSteerForwardId { get; set; }
        public double? CollisionBoxCenterX { get; set; }
        public double? CollisionBoxCenterY { get; set; }
        public double? CollisionBoxCenterZ { get; set; }
        public double? CollisionBoxOffsetX { get; set; }
        public double? CollisionBoxOffsetY { get; set; }
        public double? CollisionBoxOffsetZ { get; set; }
        public double? CollisionBoxScaleX { get; set; }
        public double? CollisionBoxScaleY { get; set; }
        public double? CollisionBoxScaleZ { get; set; }
        public double? CollisionBoxSizeX { get; set; }
        public double? CollisionBoxSizeY { get; set; }
        public double? CollisionBoxSizeZ { get; set; }
        public double? CollisionSphereRadius { get; set; }
        public string Damaged25 { get; set; }
        public string Damaged50 { get; set; }
        public string Damaged75 { get; set; }
        public string Dead { get; set; }
        public double? HaltRate { get; set; }
        public double? ImpactMass { get; set; }
        public double? KeelHeight { get; set; }
        public double? KeelLength { get; set; }
        public double? KeelOffsetZ { get; set; }
        public double? Mass { get; set; }
        public double? MassBoxSizeX { get; set; }
        public double? MassBoxSizeY { get; set; }
        public double? MassBoxSizeZ { get; set; }
        public double? MassCenterX { get; set; }
        public double? MassCenterY { get; set; }
        public double? MassCenterZ { get; set; }
        public double? MaxRpmSec { get; set; }
        public double? MinRpmSec { get; set; }
        public string Normal { get; set; }
        public double? PassengerBoxOffsetX { get; set; }
        public double? PassengerBoxOffsetY { get; set; }
        public double? PassengerBoxOffsetZ { get; set; }
        public double? PassengerBoxScaleX { get; set; }
        public double? PassengerBoxScaleY { get; set; }
        public double? PassengerBoxScaleZ { get; set; }
        public double? ReverseAccel { get; set; }
        public double? ReverseVelocity { get; set; }
        public double? SteerVel { get; set; }
        public double? TubeLength { get; set; }
        public double? TubeOffsetZ { get; set; }
        public double? TubeRadius { get; set; }
        public double? TurnAccel { get; set; }
        public double? Velocity { get; set; }
        public double? WaterDamping { get; set; }
        public double? WaterDensity { get; set; }
        public double? WaterResistance { get; set; }
    }
}
