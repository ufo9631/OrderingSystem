﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 用户表
    /// </summary>
    public class BasUsers:BaseModel
    {
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string PassWord { get; set; }
        /// <summary>
        /// 地址
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// 邮箱地址
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// 手机号码
        /// </summary>
        public string Phone { get; set; }

    }
}
