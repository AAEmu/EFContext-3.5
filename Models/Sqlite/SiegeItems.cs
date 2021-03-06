﻿namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class SiegeItems
    {
        public long Id { get; set; }
        public byte[] DuringDeclare { get; set; }
        public byte[] DuringNoDominion { get; set; }
        public byte[] DuringPeace { get; set; }
        public byte[] SiegeCircleDuringSiege { get; set; }
        public byte[] DefenseHqDuringSiege { get; set; }
        public byte[] OffenseHqDuringSiege { get; set; }
        public byte[] OutsideSiegeAreaDuringSiege { get; set; }
        public byte[] SiegeCircleDuringWarmup { get; set; }
        public byte[] DefenseHqDuringWarmup { get; set; }
        public byte[] OffenseHqDuringWarmup { get; set; }
        public byte[] OutsideSiegeAreaDuringWarmup { get; set; }
        public byte[] OutsideSiegeZone { get; set; }
        public string Usage { get; set; }
    }
}
