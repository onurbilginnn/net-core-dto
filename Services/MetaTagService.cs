using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mizgindogancom.Services
{
    public class MetaTagService : IMetaTagService
    {
        public string CreateMetas(string title, string desc, string keywords, string author, 
            string owner, int year, string thumbnailUrl, string siteUrl,
            string largeImgUrl, string siteName, string imgAltText)
        {
            desc = desc.Substring(0, 150);
            string metaSection = "<meta name=\"title\" content=\"" + title + "\"/>" +
                "<meta name=\"description\" content=\"" + desc + "\"/>" +
                "<meta name=\"keywords\" content=\"" + keywords + "\"/>" +
                "<meta name=\"author\" content=\"" + author + "\"/>" +
                "<meta name=\"owner\" content=\"" + owner + "\"/>" +
                "<meta name=\"copyright\" content=\"(c)" + year + "\"/>" +
                "<meta name=\"og:title\" content=\"" + title + "\"/>" +
                "<meta name=\"og:description\" content=\"" + desc + "\"/>" +
                "<meta name=\"og:image\" content=\"" + thumbnailUrl + "\"/>" +
                "<meta name=\"og:url\" content=\"" + siteUrl + "\"/>" +
                "<meta name=\"twitter:card\" content=\"" + largeImgUrl + "\"/>" +
                "<meta name=\"og:site_name\" content=\"" + siteName + "\"/>" +
                "<meta name=\"twitter:image:alt\" content=\"" + imgAltText + "\"/>";

            return metaSection;
        }
    }
}
