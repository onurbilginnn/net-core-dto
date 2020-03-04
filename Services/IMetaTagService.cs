using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mizgindogancom.Services
{
    public interface IMetaTagService
    {
        string CreateMetas(string title, string desc, string keywords,
            string author, string owner, int year, string thumbnailUrl, string siteUrl, string largeImgUrl,
            string siteName, string imgAltText);
    }
}
