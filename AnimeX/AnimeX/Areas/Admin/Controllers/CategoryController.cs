using AnimeX.BusinnessLayer.Concrate;
using AnimeX.DataAccessLayer.Concrate;
using AnimeX.DataAccessLayer.EntityFramework;
using AnimeX.DtoLayer.AdminCategories;
using EntityLayer;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace AnimeX.UI.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        CategoriesManager categoriesManager = new CategoriesManager(new efCatagoriesRepository(new Context()));
        [Area("Admin")]
        [Route("[controller]/[action]/{id?}")]
        [HttpGet]
        public IActionResult CategoryAdd()
        {
            return View();
        }
        [HttpPost]
        [Route("[controller]/[action]/{id?}")]
        public IActionResult CategoryAdd(CategoriesAddDto categoriesDto)
        {
          Categories categories= new Categories();
            categories.KategoriAdi=categoriesDto.KategoriAdi;
            categories.Status=categoriesDto.Status;
            categoriesManager.TInsert(categories);
          return  RedirectToAction("CategoryAdd", "Category");
        }
        [Area("Admin")]
        [Route("[controller]/[action]/{id?}")]
        public IActionResult CategoryList(int page=1)
        {
            var categoryies = categoriesManager.TGetList();
            return View(categoryies.ToPagedList(page,15));
        }
      
       
        [Area("Admin")]
        [Route("[controller]/[action]/{id?}")]
        [HttpGet]
        public IActionResult CategoryEdit(int id)
        {
            var categoryies = categoriesManager.TGetList().Where(x => x.kategoriID == id).FirstOrDefault();
         
          
            return View(categoryies);
        }
        [HttpPost]
        public IActionResult CategoryEdit(int id , CategoriesAddDto categoriesDto)
        {
            var categoryies = categoriesManager.TGetList().Where(x => x.kategoriID == id).FirstOrDefault();
            categoryies.Status=categoriesDto.Status;
            categoryies.KategoriAdi= categoriesDto.KategoriAdi;
            categoriesManager.TUpdate(categoryies, categoryies);
            return RedirectToAction("CategoryList", "Category");
        }
    }
}
