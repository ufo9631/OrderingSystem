using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OrderingSystem.Areas.Admin.Controllers
{
    /// <summary>
    /// 产品管理
    /// </summary>
    public class ProductManageController : Controller
    {
        // GET: Admin/ProductManage
        public ActionResult Index()
        {
            return View();
        }
    }
}