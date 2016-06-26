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
    /// 产品表
    /// </summary>
    [Table("BasProduct")]
    public class BasProduct:BaseModel
    {
        /// <summary>
        /// 产品名称
        /// </summary>
        [StringLength(38)]
        public string ProductName { get; set; }
        /// <summary>
        /// 产品编码
        /// </summary>
        [StringLength(28)]
        public string ProductCode { get; set; }
        /// <summary>
        /// 零售价
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// 会员价
        /// </summary>
        public double MemberPrice { get; set; }
        /// <summary>
        /// 产品默认图片
        /// </summary>
        [StringLength(128)]
        public string DefaultImage { get; set; }
        /// <summary>
        /// 产地
        /// </summary>
        [StringLength(128)]
        public string Address { get; set; }
        /// <summary>
        /// 租户id
        /// </summary>
        public int RentId { get; set; }
        /// <summary>
        /// 连锁id
        /// </summary>
        public int ChainId { get; set; }
    }
}
