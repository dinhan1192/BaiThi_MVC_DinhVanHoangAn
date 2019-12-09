using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BaiThi_MVC_DinhVanHoangAn.Models
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class BaiThi_MVC_DinhVanHoangAnContext : DbContext
    {
        public BaiThi_MVC_DinhVanHoangAnContext() : base("name=MyContext") { }
        public DbSet<Exam> Exams { get; set; }
    }
}