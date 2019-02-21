using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using Models.Framework;

namespace OnlineShop.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        private OnlineShopDbContext context = null;
        // GET: Admin/Category
        public ActionResult Index()
        {
            var obj = new CategoryModel();
            var model = obj.ListAll();
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Category collection)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    var model = new CategoryModel();
                    var res = model.Create(collection.Name, collection.Alias, collection.Idx, collection.ParentId , (collection.Status ?? false));
                    if (res > 0)
                        return RedirectToAction("Index");
                    else
                        ModelState.AddModelError("","Thêm mới dữ liệu không thành công!");
                }
                return View(collection);
            }
            catch(Exception ex)
            {
                return View();
            }

        }

    }
}