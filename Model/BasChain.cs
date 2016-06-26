using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 联锁表
    /// </summary>
    [Table("BasChain")]
    public class BasChain : BaseModel
    {
        /// <summary>
        /// 租户id
        /// </summary>
        public int RentId { get; set; }
        /// <summary>
        /// 连锁名称
        /// </summary>
        [StringLength(28)]
        public string ChainName { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
        /// <summary>
        /// 地址
        /// </summary>
        [StringLength(128)]
        public string Address { get; set; }
        /// <summary>
        /// 电话号码
        /// </summary>
        [StringLength(18)]
        public string Telephone { get; set; }
        /// <summary>
        /// 传真
        /// </summary>
        [StringLength(18)]
        public string Fax { get; set; }
    }
}
