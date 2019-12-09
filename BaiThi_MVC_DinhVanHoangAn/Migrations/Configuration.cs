namespace BaiThi_MVC_DinhVanHoangAn.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BaiThi_MVC_DinhVanHoangAn.Models.BaiThi_MVC_DinhVanHoangAnContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(BaiThi_MVC_DinhVanHoangAn.Models.BaiThi_MVC_DinhVanHoangAnContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
