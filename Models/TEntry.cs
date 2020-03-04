using System;
using System.Collections.Generic;

namespace mizgindogancom.Models
{
    public partial class TEntry
    {
        public TEntry()
        {
            TComment = new HashSet<TComment>();
        }

        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public string Header { get; set; }
        public string EntryText { get; set; }
        public string EntrySummary { get; set; }
        public string PostedBy { get; set; }
        public string Category { get; set; }
        public string Email { get; set; }
        public string ImageUrlLarge { get; set; }
        public string ImageUrlMed { get; set; }
        public string ImageUrlSmall { get; set; }
        public int? ReadTime { get; set; }
        public string ArchiveDate { get; set; }
        public string Tags { get; set; }

        public virtual ICollection<TComment> TComment { get; set; }
    }
}
