namespace _102190064_NguyenIchHoa.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<_102190064_NguyenIchHoa.DAL.DbHelper>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "_102190064_NguyenIchHoa.DAL.DbHelper";
        }

        protected override void Seed(_102190064_NguyenIchHoa.DAL.DbHelper context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
