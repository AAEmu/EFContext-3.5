using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class Books
    {
        public Books()
        {
            BookElems = new HashSet<BookElems>();
            DoodadFuncOpenPapers = new HashSet<DoodadFuncOpenPapers>();
            ItemOpenPapers = new HashSet<ItemOpenPapers>();
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<BookElems> BookElems { get; set; }
        public virtual ICollection<DoodadFuncOpenPapers> DoodadFuncOpenPapers { get; set; }
        public virtual ICollection<ItemOpenPapers> ItemOpenPapers { get; set; }
    }
}
