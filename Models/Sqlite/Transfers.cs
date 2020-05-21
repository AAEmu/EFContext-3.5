using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class Transfers
    {
        public Transfers()
        {
            TransferBindings = new HashSet<TransferBindings>();
        }

        public long Id { get; set; }
        public string Comment { get; set; }
        public byte[] Cyclic { get; set; }
        public long? ModelId { get; set; }
        public double? PathSmoothing { get; set; }
        public double? WaitTime { get; set; }
        public byte[] WaitTimeBuff { get; set; }

        public virtual Models Model { get; set; }
        public virtual ICollection<TransferBindings> TransferBindings { get; set; }
    }
}
