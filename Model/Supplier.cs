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
    /// 供应商
    /// </summary>
    [Table("Supplier")]
    public class Supplier : BaseModel
    {
        /// <summary>
        /// 供应商名称
        /// </summary>
        [StringLength(28)]
        public string SupplierName { get; set; }
        /// <summary>
        /// 供应商地址
        /// </summary>
        [StringLength(128)]
        public string Address { get; set; }
        /// <summary>
        /// 供应商电话
        /// </summary>
        [StringLength(28)]
        public string Mobile { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        [StringLength(28)]
        public string Email { get; set; }
        /// <summary>
        /// 租户id
        /// </summary>
        public int RentId { get; set; }
        /// <summary>
        /// 连锁id
        /// </summary>
        public int ChainId { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
    }
}
