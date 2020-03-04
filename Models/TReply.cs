using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mizgindogancom.Models
{
    public partial class TReply
    {
        public int Id { get; set; }
        public int? CommentId { get; set; }
        public DateTime? Date { get; set; }
        [Required(ErrorMessage = "Doldurulması zorunlu alan")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Doldurulması zorunlu alan")]
        public string ReplyText { get; set; }
        [Required(ErrorMessage = "Doldurulması zorunlu alan")]
        [EmailAddress(ErrorMessage = "Hatalı mail adresi")]
        public string Email { get; set; }
        public int? EntryId { get; set; }

        public virtual TComment Comment { get; set; }

    }
}
