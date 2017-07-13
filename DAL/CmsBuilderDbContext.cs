using System.Collections.Generic;
using DomainLogic;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class CmsBuilderDbContext : DbContext
    {
        //public CmsBuilderDbContext(): base("CmsBuilderDbContext") 
        //{
        //    this.SetInitializer(new CmsBuilderDbInitializer());

        //}

        public DbSet<Element> Elements { get; set; }
        public DbSet<Link> Links { get; set; }
        public  DbSet<Attribute> Attributes { get; set; }
        public  DbSet<AttributeValue> AttributeValues { get;set; }
    }

    //public class CmsBuilderDbInitializer : DropCreateDatabaseIfModelChanges<CmsBuilderDbContext>
    //{
    //    protected override void Seed(CmsBuilderDbContext context)
    //    {


    //        base.Seed(context);
    //    }
    //}

}
