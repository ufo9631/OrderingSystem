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
    public class BasChainBLL : BaseBLL<BasChain>, IBasChainBLL
    {
        public readonly IBasChainDAL BasChainDAL;
        public BasChainBLL(IBasChainDAL _BasChainDAL)
        {
            BasChainDAL = _BasChainDAL;
            Initialize();
        }
        public override void Initialize()
        {
            DalInstance = BasChainDAL;
        }
    }
}
