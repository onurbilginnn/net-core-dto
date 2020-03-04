using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mizgindogancom.Dtos
{
    public class BlogForTagFilterDto
    {
        public int? page { get; set; }
        public int? pageSize { get; set; }
        public string tag { get; set; }
        public string searchString { get; set; }
    }
}
