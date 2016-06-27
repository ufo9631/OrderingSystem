using IBLL;
using Model;
using Newtonsoft.Json;
using OrderingSystem.Areas.Admin.Models;
using OrderingSystem.Models;
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
        /// <summary>
        /// 添加供应商
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult AddData(Supplier model)
        {
            model.CreateTime = DateTime.Now;
            model.RentId = SiteInfo.RentId;
            model.ChainId = SiteInfo.ChainId;
            SupplierBLL.AddEntity(model);
            return Json(new { success = true, state = 1 }, JsonRequestBehavior.AllowGet);
        }
        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult EditData(Supplier model)
        {
            SupplierBLL.UpdateEntityFields(model, new List<string> { "SupplierName", "Address", "Mobile", "Email", "Remark" });
            return Json(new { success = true, state = 1 }, JsonRequestBehavior.AllowGet);
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult DeleteData(int Id)
        {
            SupplierBLL.DeleteEntity(p => p.Id == Id);
            return Json(new { success = true, state = 1 }, JsonRequestBehavior.AllowGet);
        }
    }
}