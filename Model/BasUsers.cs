using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 用户表
    /// </summary>
    [Table("BasUsers")]
    public class BasUsers : BaseModel
    {
        /// <summary>
        /// 用户名
        /// </summary>
        [StringLength(28)]
        public string UserName { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        [Required(ErrorMessage = "密码不能为空！")]
        [DataType(DataType.Password)]
        [StringLength(128)]
        public string PassWord { get; set; }
        /// <summary>
        /// 确认密码
        /// </summary>
        [NotMapped]
        [DataType(DataType.Password)]
        [Compare("PassWord", ErrorMessage = "两次密码不一致！")]
        public string ConfirmPwd { get; set; }
        /// <summary>
        /// 地址
        /// </summary>
        [StringLength(128)]
        public string Address { get; set; }
        /// <summary>
        /// 邮箱地址
        /// </summary>
        [StringLength(28)]
        public string Email { get; set; }
        /// <summary>
        /// 手机号码
        /// </summary>
        [StringLength(28)]
        public string Phone { get; set; }
        /// <summary>
        /// 租户ID
        /// </summary>
        [DefaultValue(0)]
        public int RentId { get; set; }
        /// <summary>
        /// 连锁id
        /// </summary>
        [DefaultValue(0)]
        public int ChainId { get; set; }

    }
}
