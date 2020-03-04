using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mizgindogancom.Data;
using mizgindogancom.Dtos;
using mizgindogancom.Models;
using mizgindogancom.Services;
using mizgindogancom.ViewModels;

namespace mizgindogancom.Controllers
{
    public class BlogController : Controller
    {
        private readonly IEntryRepository _entryRepo;
        private readonly IMainRepository _mainRepo;
        private readonly IEmailService _mailService;
        private readonly ICommentReplyRepository _comReplyRepo;
        private readonly IMetaTagService _metaTagService;

        private readonly string desc;
        private readonly string[] keywords;
        private readonly string owner;
        private readonly string siteName;

        BlogViewModel model = new BlogViewModel();

        public BlogController(IEntryRepository entryRepo, IMainRepository mainRepo,
            IEmailService mailService, ICommentReplyRepository comReplyRepo, IMetaTagService metaTagService)
        {
            _entryRepo = entryRepo;
            _mainRepo = mainRepo;
            _mailService = mailService;
            _comReplyRepo = comReplyRepo;
            _metaTagService = metaTagService;

            desc = "Mizgin Hukuk ve Danışmanlık, müvekkil odaklı çalışmayı ilke edinmiş genç ve" +
               " dinamik kadrosu ile müvekkillerine hukuki danışmanlık başta olmak üzere avukatlık hizmeti sağlamaktadır.";

            keywords = new string[] {"Makaleler","Yazılarımız","Hukuk Yazılarımız",
                "Avukat", "Boşanma", "Miras", "İş Hukuku","Dava","Mahkeme","Şikayet","Savcılık" };
            owner = "Av.Mizgin Doğan";
            siteName = "www.mizgindogan.com";
        }

        public async Task InitializeModel()
        {
            model.AllImages = await _mainRepo.AllImages();
            model.EntriesRecent = await _entryRepo.EntriesAllEntriesRecent(6);
            model.EntriesAll = await _entryRepo.EntriesAll();
            model.TagList = await _entryRepo.TagsToList();
            ViewBag.RecentEntries = model.EntriesRecent;

        }
        [Route("/Yazılarımız/Liste")]
        public async Task<IActionResult> BlogList(BlogForListDto blogForListDto)
        {           
            await InitializeModel();
            model.EntriesPaging = await _entryRepo.PagingBlogList(blogForListDto);
            model.Location = "YAZILARIMIZ";
            ViewBag.Blog = "class = active";
            var location = new Uri($"{Request.Scheme}://{Request.Host}{Request.Path}{Request.QueryString}");
            var url = location.AbsoluteUri;
            ViewBag.MetaTags = _metaTagService.CreateMetas("Yazılarımız | Mizgin Doğan Hukuk", desc
               , string.Join(",", keywords), owner, owner, 2019, model.AllImages.ElementAt(1).Url, url, model.AllImages.ElementAt(16).Url,
               siteName, model.AllImages.ElementAt(16).Name);
            return View(model);
        }


        [Route("/Yazılarımız/Detay/{id}")]
        // GET: Blog/Details/5
        public async Task<IActionResult> Details(BlogForDetailsDto blogForDetailsDto)
        {

            if (blogForDetailsDto.id == null)
            {
                return NotFound();
            }

            await _entryRepo.EntryDetail(blogForDetailsDto);
            await InitializeModel();
            model.Location = "YAZILARIMIZ";
            ViewBag.Blog = "class = active";

            model.Entry = blogForDetailsDto.selectedEntry;
            model.Comments = blogForDetailsDto.selectedEntryComments;
            model.RandomEntry = await _entryRepo.RandomEntry();
            while (model.RandomEntry.Id == model.Entry.Id)
            {
                model.RandomEntry = await _entryRepo.RandomEntry();
            }
            if (!String.IsNullOrEmpty(blogForDetailsDto.searchString))
            {
                return RedirectToAction("BlogList", "Blog", new { blogForDetailsDto.searchString });
            }

            if (model == null)
            {
                return NotFound();
            }
            var location = new Uri($"{Request.Scheme}://{Request.Host}{Request.Path}{Request.QueryString}");
            var url = location.AbsoluteUri;
            ViewBag.MetaTags = _metaTagService.CreateMetas($"{model.Entry.Header} | Mizgin Doğan Hukuk", model.Entry.EntrySummary
               , string.Join(",", model.Entry.Tags), model.Entry.PostedBy, owner, 2019, model.Entry.ImageUrlMed, url, model.Entry.ImageUrlLarge,
               siteName, model.Entry.Header);
            return View(model);
        }   

        [Route("/Yazılarımız/Kategori/{category}")]
        public async Task<IActionResult> CategoryFilter(BlogForCategoryFilterDto blogForCategoryFilterDto)
        {
            await InitializeModel();
            model.EntriesPaging = await _entryRepo.CategoryFilter(blogForCategoryFilterDto);

            if (!String.IsNullOrEmpty(blogForCategoryFilterDto.searchString))
            {
                return RedirectToAction("BlogList", "Blog", new { blogForCategoryFilterDto.searchString });
            }
            model.EntriesPaging = await _entryRepo.CategoryFilter(blogForCategoryFilterDto);

            return View("~/Views/Blog/BlogList.cshtml",model);
        }
        [Route("/Yazılarımız/Etiket/{tag}")]
        public async Task<IActionResult> TagFilter(BlogForTagFilterDto blogForTagFilterDto)
        {
            await InitializeModel();
            model.EntriesPaging = await _entryRepo.TagFilter(blogForTagFilterDto);

            if (!String.IsNullOrEmpty(blogForTagFilterDto.searchString))
            {
                return RedirectToAction("BlogList", "Blog", new { blogForTagFilterDto.searchString });
            }
            model.EntriesPaging = await _entryRepo.TagFilter(blogForTagFilterDto);

            return View("~/Views/Blog/BlogList.cshtml", model);
        }
        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> SaveComment(TComment comment)
        {
            if (ModelState.IsValid)
            {
                await _comReplyRepo.SaveComment(comment);
                await _mailService.MailForComment(comment);

                return RedirectToAction("Details", "Blog", new { @id = comment.EntryId });
            }
            ModelState.Clear();
            return RedirectToAction("Details", "Blog", new { @id = comment.EntryId });

        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> SaveReply(TReply reply)
        {
            if (ModelState.IsValid)
            {
                await _comReplyRepo.SaveReply(reply);
                await _mailService.MailForReply(reply);

                return RedirectToAction("Details", "Blog", new { @id = reply.EntryId });
            }
            ModelState.Clear();
            return RedirectToAction("Details", "Blog", new { @id = reply.EntryId });
        }

    }
}