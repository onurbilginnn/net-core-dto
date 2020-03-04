using mizgindogancom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mizgindogancom.Data
{
    public interface IMainRepository
    {
        Task<TInfo> FirstInfo();
        Task<ICollection<TImage>> AllImages();
    }
}
