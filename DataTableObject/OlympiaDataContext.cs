using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace DataTableObject
{
    public class OlympiaDataContext: DbContext
    {
        public DbSet<CauHoi> CauHois { get; set; }
        public DbSet<GoiCauHoi> GoiCauHois { get; set; }

        public OlympiaDataContext()
            :base("OlympiaDB")
        {
            Database.SetInitializer<OlympiaDataContext>(new TaoDB());
        }

        class TaoDB: CreateDatabaseIfNotExists<OlympiaDataContext>
        {
            protected override void Seed(OlympiaDataContext context)
            {
                //context.GoiCauHois.Add(new GoiCauHoi { Ten = "Mặc định" });
                //context.SaveChanges();
            }
        }
    }
}
