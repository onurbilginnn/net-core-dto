# Dot Net Core DTO Project

DTO;

   
    public class BlogForCategoryFilterDto
      {
        public int? page { get; set; }
        public int? pageSize { get; set; }
        public string category { get; set; }
        public string searchString { get; set; }
       }
   
   All DTO models are included inside ViewModel so the view is sending the data with ViewModel to controller, and controller is getting the data with the help of DTO.
   
Inside Controller;   
       
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
    
  Also <strong>Sakura MVC Paging</strong> package and <strong>e-mail service</strong> are included inside the project.
