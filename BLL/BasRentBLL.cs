using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDAL;
namespace BLL
{
    public class BasRentBLL : BaseBLL<BasRent>
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
