using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDAL;
using IBLL;

namespace BLL
{
    public class BasProductBLL : BaseBLL<BasProduct>, IBasProductBLL
    {
        public readonly IBasProductDAL BasProductDAL;
        public BasProductBLL(IBasProductDAL _BasProductDAL)
        {
            BasProductDAL = _BasProductDAL;
            Initialize();
        }
        public override void Initialize()
        {
            DalInstance = BasProductDAL;
        }
    }
}
