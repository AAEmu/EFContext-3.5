namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class UnitFormulaVariables
    {
        public long Id { get; set; }
        public long? Key { get; set; }
        public long? UnitFormulaId { get; set; }
        public double? Value { get; set; }
        public long? VariableKindId { get; set; }

        public virtual UnitFormulas UnitFormula { get; set; }
    }
}
