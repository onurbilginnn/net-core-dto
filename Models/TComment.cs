using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mizgindogancom.Models
{
    public partial class TComment
    {
        public TComment()
        {
            TReply = new HashSet<TReply>();
        }

        public int Id { get; set; }
        public int? EntryId { get; set; }
        public DateTime? Date { get; set; }
        [Required(ErrorMessage = "Doldurulması zorunlu alan")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Doldurulması zorunlu alan")]
        public string CommentText { get; set; }
        [Required(ErrorMessage = "Doldurulması zorunlu alan")]
        [EmailAddress(ErrorMessage = "Hatalı mail adresi")]
        public string Email { get; set; }

        public virtual TEntry Entry { get; set; }
        public virtual ICollection<TReply> TReply { get; set; }

    }
}
