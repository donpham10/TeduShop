namespace TeduShop.Data.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Model.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TeduShop.Data.TeduShopDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TeduShop.Data.TeduShopDbContext context)
        {
            CreateProductCategorySample(context);
            //  This method will be called after migrating to the latest version.
            //var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new TeduShopDbContext()));
            //var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new TeduShopDbContext()));
            //var user = new ApplicationUser()
            //{
            //    UserName = "Tedu",
            //    Email = "tedu.international@gmail.com",
            //    BirthDay = DateTime.Now,
            //    FullName = "Technology Education"
            //};
            //manager.Create(user, "123654$");

            //if(!roleManager.Roles.Any())
            //{
            //    roleManager.Create(new IdentityRole { Name = "Admin" });
            //    roleManager.Create(new IdentityRole { Name = "User" });
            //}
            //var adminUser = manager.FindByEmail("tedu.international@gmail.com");

            //manager.AddToRoles(adminUser.Id, new string[] { "Admin", "User" });
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
        private void CreateProductCategorySample(TeduShop.Data.TeduShopDbContext Context)
        {
            if (Context.ProductCategories.Count() == 0)
            {
                List<ProductCategory> ListProductCategory = new List<ProductCategory>()
            {
                new ProductCategory() { Name ="Diện Lạnh", Alias="Dien-Lanh", Status=true },
                new ProductCategory() { Name ="Viên Thông", Alias="Vien-Thong", Status=true },
                new ProductCategory() { Name ="Đồ Gia Dụng", Alias="Do-Gia-Dung", Status=true },
                new ProductCategory() { Name ="Mỹ Phẩm", Alias="My-Pham", Status=true }
            };
                Context.ProductCategories.AddRange(ListProductCategory);
                Context.SaveChanges();
            }

        }
    }
}
