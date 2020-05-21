namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class DoodadFuncBubbles
    {
        public long Id { get; set; }
        public long? BubbleId { get; set; }

        public virtual Bubbles Bubble { get; set; }
    }
}
