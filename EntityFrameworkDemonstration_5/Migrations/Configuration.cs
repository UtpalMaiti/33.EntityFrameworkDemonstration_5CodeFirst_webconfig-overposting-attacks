namespace EntityFrameworkDemonstration_5.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EntityFrameworkDemonstration_5.DAL.PragimDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "EntityFrameworkDemonstration_5.DAL.PragimDbContext";
        }

        protected override void Seed(EntityFrameworkDemonstration_5.DAL.PragimDbContext context)
        {
            var courseList = new List<Course>
            {
                new Course {CourseId=1005,Name="Asp.Net MVC",DurationInDays=90,Price=20000 },
                new Course {CourseId=1010,Name="Java",DurationInDays=120,Price=20000 },
                new Course {CourseId=1015,Name="DevOps",DurationInDays=50,Price=15000 },
                new Course {CourseId=1020,Name="Testing",DurationInDays=45,Price=12000 }
            };

            courseList.ForEach(c =>
            {
                context.Courses.AddOrUpdate(c);
            });

            context.SaveChanges();
        }
    }
}
