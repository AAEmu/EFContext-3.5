using System.Collections.Generic;

namespace AAEmu.Shared.Database.Models.Sqlite
{
    public partial class BookPages
    {
        public BookPages()
        {
            BookElems = new HashSet<BookElems>();
            BookPageContents = new HashSet<BookPageContents>();
            DoodadFuncOpenPapers = new HashSet<DoodadFuncOpenPapers>();
            ItemOpenPapers = new HashSet<ItemOpenPapers>();
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<BookElems> BookElems { get; set; }
        public virtual ICollection<BookPageContents> BookPageContents { get; set; }
        public virtual ICollection<DoodadFuncOpenPapers> DoodadFuncOpenPapers { get; set; }
        public virtual ICollection<ItemOpenPapers> ItemOpenPapers { get; set; }
    }
}
