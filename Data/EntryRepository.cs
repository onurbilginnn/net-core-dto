using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using mizgindogancom.Dtos;
using mizgindogancom.Models;
using Sakura.AspNetCore;

namespace mizgindogancom.Data
{
    public class EntryRepository : IEntryRepository
    {
        private readonly MizginDoganDBContext _context;

        public EntryRepository(MizginDoganDBContext context)
        {
            _context = context;
        }
    

        public async Task<ICollection<TEntry>> EntriesAll()
        {
            var entriesAll = await _context.TEntry.Select(x => x)
                .OrderByDescending(x => x.Date).ToListAsync();

            return entriesAll;
        }
    

        public async Task<ICollection<TEntry>> EntriesAllEntriesRecent(int num)
        {
            var entriesAllEntriesRecent4 = await _context.TEntry.OrderByDescending(x => x.Date).Take(num).ToListAsync();

            return entriesAllEntriesRecent4;
        }
            

        public async Task<IPagedList<TEntry>> PagingBlogList(BlogForListDto blogForListDto)
        {
            int no = blogForListDto.page ?? 1;
            int size = blogForListDto.pageSize ?? 4;
            var entries = await EntriesAll();

            if (!String.IsNullOrEmpty(blogForListDto.searchString))
            {
                blogForListDto.searchString = blogForListDto.searchString.ToLower();
                entries = entries.Where(s => s.Header.ToLower().Contains(blogForListDto.searchString) ||
                                             s.Tags.ToLower().Contains(blogForListDto.searchString) ||
                                             s.Category.ToLower().Contains(blogForListDto.searchString)).ToList();
            }
            var entriesPaging = entries.ToPagedList(size, no);         

            return entriesPaging;
        }

        public async Task<ICollection<string>> TagsToList()
        {        
            var tagList = new List<string>();
            Random random = new Random();
            int tagListLength = await CreateTagList(tagList);
            int randNo = random.Next(tagListLength - 8);
            tagList = tagList.Skip(randNo).Take(10).ToList();
            return tagList;
        }

    

        public async Task EntryDetail(BlogForDetailsDto blogForDetailsDto)
        {
            blogForDetailsDto.selectedEntry = await _context.TEntry.FirstOrDefaultAsync(m => m.Id == blogForDetailsDto.id);

            blogForDetailsDto.selectedEntryComments = await _context.TComment.Where(c => c.EntryId == blogForDetailsDto.selectedEntry.Id).ToListAsync();

            foreach (var comment in blogForDetailsDto.selectedEntryComments)
            {
                comment.TReply = await _context.TReply.Where(r => r.CommentId == comment.Id).ToListAsync();
            }

        }

        public async Task<IPagedList<TEntry>> CategoryFilter(BlogForCategoryFilterDto blogForCategoryFilterDto)
        {

            int no = blogForCategoryFilterDto.page ?? 1;
            int size = blogForCategoryFilterDto.pageSize ?? 4;
            var entries = await EntriesAll();
            var entriesPaging = entries.ToPagedList(size, no);

            if (!String.IsNullOrEmpty(blogForCategoryFilterDto.category))
            {
                entriesPaging = entries.Where(s => s.Category == blogForCategoryFilterDto.category).ToPagedList(size, no);
            }

            return entriesPaging;
        }
        public async Task<IPagedList<TEntry>> TagFilter(BlogForTagFilterDto blogForTagFilterDto)
        {

            int no = blogForTagFilterDto.page ?? 1;
            int size = blogForTagFilterDto.pageSize ?? 4;
            var entries = await EntriesAll();
            var tagList = new List<TEntry>();

            if (!String.IsNullOrEmpty(blogForTagFilterDto.tag))
            {
                foreach (var entry in entries.Select(x => x))
                {
                    if (entry.Tags.Contains(blogForTagFilterDto.tag))
                    {
                        tagList.Add(entry);
                    }
                }
            }
            var entriesPaging = tagList.ToPagedList(size, no);

            return entriesPaging;
        }

        public async Task<int> CreateTagList(List<string> tagList)
        {
            var allTagsRaw = await _context.TEntry.Select(x => x.Tags).Distinct().ToArrayAsync();
            foreach (var tag in allTagsRaw)
            {
                tagList.AddRange(tag.Split(','));
            }
            tagList = tagList.Distinct().ToList();
            int tagListLength = tagList.Count();

            return tagListLength;
        }

        public async Task<TEntry> RandomEntry()
        {
            var entriesAll = await EntriesAll();
            Random random = new Random();
            int randNo = random.Next(entriesAll.Count);
            var entry = entriesAll.ElementAt(randNo);
            return entry;
        }
    }
}
