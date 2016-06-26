using IBLL;
using Model;
using Newtonsoft.Json;
using OrderingSystem.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OrderingSystem.Areas.Admin.Controllers
{
    /// <summary>
    /// 供应商管理
    /// </summary>
    public class SupplierManageController : AdminBaseController
    {
        public readonly ISupplierBLL SupplierBLL;
        public SupplierManageController() { }
        public SupplierManageController(ISupplierBLL _SupplierBLL)
        {
            SupplierBLL = _SupplierBLL;
        }
        // GET: Admin/SupplierManage
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 查询列表数据
        /// </summary>
        /// <param name="page"></param>
        /// <param name="rows"></param>
        /// <returns></returns>
        public ActionResult GetDataList(int? page, int? rows)
        {
            int total = 0;
            IList<Supplier> list = SupplierBLL.GetEntityList(null, out total).ToList();
            //Total = total;
            //JsonData = JsonConvert.SerializeObject(list);
            //return JsonList();\
            return Json(new { total = total, rows = list }, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult AddData(Supplier model)
        {
            model.CreateTime = DateTime.Now;
            SupplierBLL.AddEntity(model);
            return Json(new { success = true, state = 1 }, JsonRequestBehavior.AllowGet);

        }
    }
}