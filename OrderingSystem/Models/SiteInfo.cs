using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace OrderingSystem.Models
{
    /// <summary>
    /// 站点信息
    /// </summary>
    public class SiteInfo
    {
        public static HttpRequest Request
        {
            get
            {
                return HttpContext.Current.Request;
            }
        }

        public static HttpResponse Response
        {
            get
            {
                return HttpContext.Current.Response;
            }
        }
        /// <summary>
        /// 租户ID
        /// </summary>
        public static int RentId
        {
            get
            {

                return StringUitls.ToInt(Request["RentId"]);
            }
        }
        /// <summary>
        /// 租户ID
        /// </summary>
        public static int ChainId
        {
            get
            {
                return StringUitls.ToInt(Request["ChainId"]);
            }
        }

    }
}
