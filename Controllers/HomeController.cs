using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using mizgindogancom.Data;
using mizgindogancom.Models;
using mizgindogancom.Services;
using mizgindogancom.ViewModels;

namespace mizgindogancom.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEntryRepository _entryRepo;
        private readonly IMainRepository _mainRepo;
        private readonly IEmailService _mailService;
        private readonly IMetaTagService _metaTagService;
        private readonly string desc;
        private readonly string[] keywords;
        private readonly string author;
        private readonly string siteName;


        HomeViewModel model = new HomeViewModel();

    
        public HomeController(IEntryRepository entryRepo, IMainRepository mainRepo,
            IEmailService mailService, IMetaTagService metaTagService)
        {
            _entryRepo = entryRepo;
            _mainRepo = mainRepo;
            _mailService = mailService;
            _metaTagService = metaTagService;
            desc = "Mizgin Hukuk ve Danışmanlık, müvekkil odaklı çalışmayı ilke edinmiş genç ve" +
                " dinamik kadrosu ile müvekkillerine hukuki danışmanlık başta olmak üzere avukatlık hizmeti sağlamaktadır.";
                             
            keywords = new string[] { "Mizgin Doğan Hukuk Bürosu", "Avukatlık Bürosu",
                "Avukat", "Boşanma", "Miras", "İş Hukuku","Dava","Mahkeme","Şikayet","Savcılık" };
            author = "Av.Mizgin Doğan";
            siteName = "www.mizgindogan.com";
        }

        public async Task InitializeModel()
        {
            model.AllImages = await _mainRepo.AllImages();
            model.Info = await _mainRepo.FirstInfo();
            model.EntriesRecent = await _entryRepo.EntriesAllEntriesRecent(6);
            ViewBag.RecentEntries = model.EntriesRecent;
        }

        public async Task<IActionResult> Index()
        {
            await InitializeModel();
            model.EntriesRecent = await _entryRepo.EntriesAllEntriesRecent(6);
            ViewBag.Home = "class = active";
            var location = new Uri($"{Request.Scheme}://{Request.Host}{Request.Path}{Request.QueryString}");
            var url = location.AbsoluteUri;
            ViewBag.MetaTags = _metaTagService.CreateMetas("Anasayfa | Mizgin Doğan Hukuk", desc
               , string.Join(",",keywords), author, author, 2019, model.AllImages.ElementAt(1).Url, url, model.AllImages.ElementAt(16).Url,
               siteName, model.AllImages.ElementAt(16).Name);
                                    
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Index([FromBody]MailModel mailModel)
        {
            await InitializeModel();           
            ViewBag.Home = "class = active";
            await _mailService.MailForMessage(mailModel);
           
            return Ok();

        }
        [Route("/Hakkımızda")]
        public async Task<IActionResult> About()
        {
            await InitializeModel();
            model.Location = "HAKKIMIZDA";
            ViewBag.About = "class = active";
            var location = new Uri($"{Request.Scheme}://{Request.Host}{Request.Path}{Request.QueryString}");
            var url = location.AbsoluteUri;
            ViewBag.MetaTags = _metaTagService.CreateMetas("Hakkımızda | Mizgin Doğan Hukuk", desc
               , string.Join(",", keywords), author, author, 2019, model.AllImages.ElementAt(1).Url, url, model.AllImages.ElementAt(16).Url,
               siteName, model.AllImages.ElementAt(16).Name);
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> About([FromBody]MailModel mailModel)
        {
            await InitializeModel();
            model.EntriesRecent = await _entryRepo.EntriesAllEntriesRecent(6);
            ViewBag.Home = "class = active";
            await _mailService.MailForMessage(mailModel);

            return Ok();

        }

        [Route("/FaaliyetAlanlarımız")]
        public async Task<IActionResult> Service()
        {
            await InitializeModel();
            model.Location = "FAALİYET ALANLARIMIZ";
            ViewBag.Service = "class = active";
            var location = new Uri($"{Request.Scheme}://{Request.Host}{Request.Path}{Request.QueryString}");
            var url = location.AbsoluteUri;
            ViewBag.MetaTags = _metaTagService.CreateMetas("Faaliyet Alanlarımız | Mizgin Doğan Hukuk", desc
               , string.Join(",", keywords), author, author, 2019, model.AllImages.ElementAt(1).Url, url, model.AllImages.ElementAt(16).Url,
               siteName, model.AllImages.ElementAt(16).Name);
            return View(model);
        }

        [Route("/Ekibimiz")]
        public async Task<IActionResult> Team()
        {
            await InitializeModel();
            model.Location = "EKİBİMİZ";
            ViewBag.Team = "class = active";
            var location = new Uri($"{Request.Scheme}://{Request.Host}{Request.Path}{Request.QueryString}");
            var url = location.AbsoluteUri;
            ViewBag.MetaTags = _metaTagService.CreateMetas("Ekibimiz | Mizgin Doğan Hukuk", desc
               , string.Join(",", keywords), author, author, 2019, model.AllImages.ElementAt(1).Url, url, model.AllImages.ElementAt(16).Url,
               siteName, model.AllImages.ElementAt(16).Name);
            return View(model);
        }
        [Route("/İletişim")]
        public async Task<IActionResult> Contact()
        {
            await InitializeModel();
            model.Location = "İLETİŞİM";
            ViewBag.Contact = "class = active";
            var location = new Uri($"{Request.Scheme}://{Request.Host}{Request.Path}{Request.QueryString}");
            var url = location.AbsoluteUri;
            ViewBag.MetaTags = _metaTagService.CreateMetas("İletişim | Mizgin Doğan Hukuk", desc
               , string.Join(",", keywords), author, author, 2019, model.AllImages.ElementAt(1).Url, url, model.AllImages.ElementAt(16).Url,
               siteName, model.AllImages.ElementAt(16).Name);
            return View(model);
        }
        [Route("/GizlilikSözleşmesi")]
        public async Task<IActionResult> Privacy()
        {
            await InitializeModel();
            var location = new Uri($"{Request.Scheme}://{Request.Host}{Request.Path}{Request.QueryString}");
            var url = location.AbsoluteUri;
            ViewBag.MetaTags = _metaTagService.CreateMetas("Gizlilik Sözleşmesi | Mizgin Doğan Hukuk", desc
               , string.Join(",", keywords), author, author, 2019, model.AllImages.ElementAt(1).Url, url, model.AllImages.ElementAt(16).Url,
               siteName, model.AllImages.ElementAt(16).Name);
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Contact([FromBody]MailModel mailModel)
        {
            await InitializeModel();
            model.EntriesRecent = await _entryRepo.EntriesAllEntriesRecent(6);
            ViewBag.Home = "class = active";
            await _mailService.MailForMessage(mailModel);

            return Ok();
        }


        public async Task<IActionResult> Error()
        {
            await InitializeModel();
            var location = new Uri($"{Request.Scheme}://{Request.Host}{Request.Path}{Request.QueryString}");
            var url = location.AbsoluteUri;
            ViewBag.MetaTags = _metaTagService.CreateMetas("Hata | Mizgin Doğan Hukuk", desc
               , string.Join(",", keywords), author, author, 2019, model.AllImages.ElementAt(1).Url, url, model.AllImages.ElementAt(16).Url,
               siteName, model.AllImages.ElementAt(16).Name);
            return View();
        }

     

    }
}
