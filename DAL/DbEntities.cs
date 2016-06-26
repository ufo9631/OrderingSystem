using Model;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DbEntities : DbContext
    {
        public DbEntities()
        {
        }

        public IDbSet<BasChain> BasChain { get; set; }
        public IDbSet<BasProduct> BasProduct { get; set; }
        public IDbSet<BasRent> BasRent { get; set; }
        public IDbSet<BasUsers> BasUsers { get; set; }
        public IDbSet<ProductImages> ProductImages { get; set; }
        public IDbSet<Supplier> Supplier { get; set; }

        public DbEntities(DbConnection connection, bool contextOwnsConnection)
            : base(connection, contextOwnsConnection)
        {
        }
    }
}
