﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mizgindogancom.Dtos
{
    public class BlogForCategoryFilterDto
    {
        public int? page { get; set; }
        public int? pageSize { get; set; }
        public string category { get; set; }
        public string searchString { get; set; }
    }
}
