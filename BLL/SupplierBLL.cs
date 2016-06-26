using IBLL;
using IDAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SupplierBLL : BaseBLL<Supplier>, ISupplierBLL
    {
        public readonly ISupplierDAL SupplierDAL;
        public SupplierBLL(ISupplierDAL _SupplierDAL)
        {
            SupplierDAL = _SupplierDAL;
            Initialize();
        }
        public override void Initialize()
        {
            DalInstance = SupplierDAL;
        }
    }
}
