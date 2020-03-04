using mizgindogancom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mizgindogancom.Dtos
{
    public class BlogForDetailsDto
    {
        public int? id { get; set; }
        public string searchString { get; set; }

        public TEntry selectedEntry { get; set; }
        public ICollection<TComment> selectedEntryComments { get; set; }
    }
}
