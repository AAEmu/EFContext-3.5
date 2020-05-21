using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class UnitFormulas
    {
        public UnitFormulas()
        {
            UnitFormulaVariables = new HashSet<UnitFormulaVariables>();
        }

        public long Id { get; set; }
        public string Formula { get; set; }
        public long? KindId { get; set; }
        public long? OwnerTypeId { get; set; }

        public virtual ICollection<UnitFormulaVariables> UnitFormulaVariables { get; set; }
    }
}
