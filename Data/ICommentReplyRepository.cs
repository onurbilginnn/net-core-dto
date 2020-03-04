using mizgindogancom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mizgindogancom.Data
{
    public interface ICommentReplyRepository
    {
        Task<bool> SaveComment(TComment comment);
        Task<bool> SaveReply(TReply reply);
    }
}
