using mizgindogancom.Dtos;
using mizgindogancom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sakura.AspNetCore;

namespace mizgindogancom.Data
{
    public interface IEntryRepository
    {
        Task<ICollection<TEntry>> EntriesAll();
        Task<TEntry> RandomEntry();
        Task<ICollection<TEntry>> EntriesAllEntriesRecent(int num);
        Task EntryDetail(BlogForDetailsDto blogForDetailsDto);
        Task<IPagedList<TEntry>> PagingBlogList(BlogForListDto blogForListDto);
        Task<ICollection<string>> TagsToList();
        Task<IPagedList<TEntry>> CategoryFilter(BlogForCategoryFilterDto blogForCategoryFilterDto);
        Task<IPagedList<TEntry>> TagFilter(BlogForTagFilterDto blogForTagFilterDto);

    }
}
