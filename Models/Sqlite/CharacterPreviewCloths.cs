namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class CharacterPreviewCloths
    {
        public long Id { get; set; }
        public long? CharacterId { get; set; }
        public long? EquipPackClothId { get; set; }
        public long? IconId { get; set; }
        public long? UiOrder { get; set; }

        public virtual Characters Character { get; set; }
        public virtual EquipPackCloths EquipPackCloth { get; set; }
        public virtual Icons Icon { get; set; }
    }
}
