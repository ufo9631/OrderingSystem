using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 产品图片表
    /// </summary>
    public class ProductImages : BaseModel
    {
        /// <summary>
        /// 租户id
        /// </summary>
        public int RentId { get; set; }
        /// <summary>
        /// 连锁id
        /// </summary>
        public int ChainId { get; set; }
        /// <summary>
        /// 产品id
        /// </summary>
        public int ProductId { get; set; }
        /// <summary>
        /// 图片地址
        /// </summary>
        [StringLength(128)]
        public string OriginalImageUrl { get; set; }
        /// <summary>
        /// 缩略图
        /// </summary>
        [StringLength(128)]
        public string ThumbImageUrl { get; set; }
    }
}
