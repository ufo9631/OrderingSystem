using System;
using System.Collections.Generic;
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
        public string ProductName { get; set; }  
        /// <summary>
        /// 产品编码
        /// </summary>
        public string ProductCode { get; set; }
        /// <summary>
        /// 零售价
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// 会员价
        /// </summary>
        public double MemberPrice { get; set; }
    }
}
