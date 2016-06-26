using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace OrderingSystem.Areas.Admin.Models
{
    public class AdminBaseController : Controller
    {

        /// <summary>
        /// 消息
        /// </summary>
        public string Msg { get; set; }


        public string JsonData { get; set; }

        public bool State
        {
            get;
            set;
        }
        public int Total { get; set; }



        public JsonResult JsonList()
        {
            var _list = new
            {
                msg = Msg,
                state = State,
                rows = JsonData,
                total = Total
            };
            return Json(_list, JsonRequestBehavior.AllowGet);
        }
    }
}
