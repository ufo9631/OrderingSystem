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
    public class BasRentBLL : BaseBLL<BasRent>, IBasRentBLL
    {
        public readonly IBasRentDAL BasRentDAL;
        public BasRentBLL(IBasRentDAL _BasRentDAL)
        {
            BasRentDAL = _BasRentDAL;
            Initialize();
        }
        public override void Initialize()
        {
            DalInstance = BasRentDAL;
        }
    }
}
