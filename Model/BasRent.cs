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
    /// 租户表
    /// </summary>
    [Table("BasRent")]
    public class BasRent : BaseModel
    {
        /// <summary>
        /// 租户名称
        /// </summary>
        [StringLength(28)]
        public string RentName { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
        /// <summary>
        /// 连锁数
        /// </summary>
        public int ChainNum { get; set; }
        /// <summary>
        /// 电话号码
        /// </summary>
        [StringLength(28)]
        public string Telephone { get; set; }
        /// <summary>
        /// 传真
        /// </summary>
        [StringLength(28)]
        public string Fax { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime? ModifyTime { get; set; }
        /// <summary>
        /// 地址
        /// </summary>
        [StringLength(128)]
        public string Address { get; set; }
    }
}
