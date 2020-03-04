using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mizgindogancom.Models;

namespace mizgindogancom.ViewModels
{
    public class HomeViewModel
    {
        public string Location { get; set; }
        public TInfo Info { get; set; }
        public MailModel mailModel { get; set; }
        public ICollection<TEntry> EntriesRecent { get; set; }
        public ICollection<TImage> AllImages { get; set; }
        public string MailSentMsg { get; set; }


    }
}
