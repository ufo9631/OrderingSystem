using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDAL;
namespace BLL
{
    public class BasChainBLL : BaseBLL<BasChain>
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
