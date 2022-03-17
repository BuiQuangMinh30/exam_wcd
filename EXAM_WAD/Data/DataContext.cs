using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EXAM_WAD.Data
{
    public class DataContext : DbContext
    {
        public DataContext() : base("ConnectionString")
        {

        }

        public System.Data.Entity.DbSet<EXAM_WAD.Models.Category> Categories { get; set; }

        public System.Data.Entity.DbSet<EXAM_WAD.Models.Product> Products { get; set; }
    }
}