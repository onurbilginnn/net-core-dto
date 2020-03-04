using mizgindogancom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mizgindogancom.Data
{
    public class CommentReplyRepository : ICommentReplyRepository
    {
        private readonly MizginDoganDBContext _context;

        public CommentReplyRepository(MizginDoganDBContext context)
        {
            _context = context;
        }

        public async Task<bool> SaveComment(TComment comment)
        {
            try
            {
                _context.Add(comment);
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }

        }

        public async Task<bool> SaveReply(TReply reply)
        {
            try
            {
                _context.Add(reply);
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
