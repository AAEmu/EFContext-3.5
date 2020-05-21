using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class ActorModels
    {
        public ActorModels()
        {
            GameStances = new HashSet<GameStances>();
        }

        public long Id { get; set; }
        public double? ActorHeight { get; set; }
        public byte[] AddBox { get; set; }
        public string AnimationGraph { get; set; }
        public double? AttackStartRange { get; set; }
        public double? BeanstalkBack { get; set; }
        public double? BoxX { get; set; }
        public double? BoxY { get; set; }
        public double? BoxZ { get; set; }
        public double? CenterX { get; set; }
        public double? CenterY { get; set; }
        public double? CenterZ { get; set; }
        public byte[] FaceTargetInstantly { get; set; }
        public byte[] FlyMode { get; set; }
        public double? FxScale { get; set; }
        public double? GameBackwardDiagonalMultiplier { get; set; }
        public double? GameBackwardMultiplier { get; set; }
        public double? GameBowLookIkBlendHead { get; set; }
        public double? GameBowLookIkBlendNeck { get; set; }
        public double? GameBowLookIkBlendSpine1 { get; set; }
        public double? GameBowLookIkBlendSpine2 { get; set; }
        public double? GameBowLookIkBlendSpine3 { get; set; }
        public double? GameForwardDiagonalMultiplier { get; set; }
        public double? GameForwardMultiplier { get; set; }
        public double? GameGrabMultiplier { get; set; }
        public double? GameInertia { get; set; }
        public double? GameInertiaAccel { get; set; }
        public double? GameJumpHeight { get; set; }
        public long? GameLeanAngle { get; set; }
        public double? GameLeanShift { get; set; }
        public double? GameLookIkBlendHead { get; set; }
        public double? GameLookIkBlendNeck { get; set; }
        public double? GameLookIkBlendSpine1 { get; set; }
        public double? GameLookIkBlendSpine2 { get; set; }
        public double? GameLookIkBlendSpine3 { get; set; }
        public long? GameMaxGrabMass { get; set; }
        public double? GameMaxGrabVolume { get; set; }
        public double? GameSprintMultiplier { get; set; }
        public double? GameStrafeMultiplier { get; set; }
        public double? GameWalkBackwardDiagonalMultiplier { get; set; }
        public double? GameWalkBackwardMultiplier { get; set; }
        public double? GameWalkForwardDiagonalMultiplier { get; set; }
        public double? GameWalkMultiplier { get; set; }
        public double? GameWalkStrafeMultiplier { get; set; }
        public byte[] GroundTargetable { get; set; }
        public double? HandRate { get; set; }
        public double? Height { get; set; }
        public long? HitPower { get; set; }
        public double? HropeDown { get; set; }
        public string ModelFile { get; set; }
        public long? MovementId { get; set; }
        public long? PhysicsFlags { get; set; }
        public double? PhysicsLivingAirResistance { get; set; }
        public string PhysicsLivingColliderMat { get; set; }
        public double? PhysicsLivingGravity { get; set; }
        public double? PhysicsLivingKAirControl { get; set; }
        public long? PhysicsLivingMass { get; set; }
        public double? PhysicsLivingMaxClimbAngle { get; set; }
        public long? PhysicsLivingMaxVelGround { get; set; }
        public double? PhysicsLivingMinFallAngle { get; set; }
        public double? PhysicsLivingMinSlideAngle { get; set; }
        public double? PhysicsLivingTimeImpulseRecover { get; set; }
        public long? PhysicsMass { get; set; }
        public long? PhysicsStiffnessScale { get; set; }
        public string Portrait { get; set; }
        public byte[] PushRagdoll { get; set; }
        public double? Radius { get; set; }
        public byte[] RestrictBoardingMate { get; set; }
        public byte[] RestrictBoardingSlave { get; set; }
        public byte[] RestrictClimb { get; set; }
        public double? RopeBack { get; set; }
        public double? RopeHangingHandOffsetX { get; set; }
        public double? RopeHangingHandOffsetY { get; set; }
        public double? RopeHangingHandOffsetZ { get; set; }
        public byte[] SharedDummyModel { get; set; }
        public double? SightFov { get; set; }
        public double? SightRange { get; set; }
        public byte[] SlopeAlignment { get; set; }
        public double? TurnSpeed { get; set; }
        public byte[] UnderwaterCreature { get; set; }
        public string UpperbodyGraph { get; set; }
        public byte[] UseRagdoll { get; set; }
        public byte[] UseRagdollHit { get; set; }
        public byte[] UseRagdollKnockDown { get; set; }
        public byte[] UseRandomIdleControl { get; set; }

        public virtual ICollection<GameStances> GameStances { get; set; }
    }
}
