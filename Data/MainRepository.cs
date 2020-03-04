using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using mizgindogancom.Models;

namespace mizgindogancom.Data
{
    public class MainRepository : IMainRepository
    {
        private readonly MizginDoganDBContext _context;

        public MainRepository(MizginDoganDBContext context)
        {
            _context = context;
        }
        public async Task<ICollection<TImage>> AllImages()
        {
            var imagesAll = await _context.TImage.Select(x => x).ToListAsync();

            return imagesAll;
        }

        public async Task<TInfo> FirstInfo()
        {
            var infoAll = await _context.TInfo.FirstOrDefaultAsync();

            return infoAll;
        }
    }
}
