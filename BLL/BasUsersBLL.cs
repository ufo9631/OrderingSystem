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
    public class BasUsersBLL : BaseBLL<BasUsers>, IBasUsersBLL
    {
        public readonly IBasUsersDAL BasUsersDAL;
        public BasUsersBLL(IBasUsersDAL _BasUsersDAL)
        {
            BasUsersDAL = _BasUsersDAL;
            Initialize();
        }
        public override void Initialize()
        {
            DalInstance = BasUsersDAL;
        }
    }
}
