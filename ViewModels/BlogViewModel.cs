using mizgindogancom.Models;
using Sakura.AspNetCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mizgindogancom.ViewModels
{
    public class BlogViewModel
    {
        public string Location { get; set; }
        public TEntry Entry { get; set; }
        public TEntry RandomEntry { get; set; }
        public TComment Comment { get; set; }
        public TReply Reply { get; set; }
        public ICollection<TComment> Comments { get; set; }
        public ICollection<TImage> AllImages { get; set; }
        public ICollection<TEntry> EntriesAll { get; set; }
        public ICollection<TEntry> EntriesRecent { get; set; }
        public ICollection<string> TagList { get; set; }
        public IPagedList<TEntry> EntriesPaging{ get; set; }
    }
}
