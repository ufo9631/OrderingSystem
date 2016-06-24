using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 联锁表
    /// </summary>
   public class BasChain:BaseModel
    {
        /// <summary>
        /// 租户id
        /// </summary>
        public int RentId { get; set; }
        /// <summary>
        /// 连锁名称
        /// </summary>
        public string ChainName { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
        /// <summary>
        /// 地址
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// 电话号码
        /// </summary>
        public string Telephone { get; set; }
        /// <summary>
        /// 传真
        /// </summary>
        public string Fax { get; set; }
    }
}
