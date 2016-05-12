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
        public DbSet<User> Users { get; set; }

        public OlympiaDataContext()
            :base("OlympiaDB")
        {
            Database.SetInitializer<OlympiaDataContext>(new TaoDB());
        }

        class TaoDB: CreateDatabaseIfNotExists<OlympiaDataContext>
        {
            protected override void Seed(OlympiaDataContext context)
            {
                context.GoiCauHois.Add(new GoiCauHoi { Ten = "Gói Khởi Động 1" });
                context.GoiCauHois.Add(new GoiCauHoi { Ten = "Gói Tăng Tốc 1" });
                context.GoiCauHois.Add(new GoiCauHoi { Ten = "Gói Vượt Chướng Ngại Vật 1" });
                context.GoiCauHois.Add(new GoiCauHoi { Ten = "Gói Về Đích 40 1" });
                context.SaveChanges();
            }
        }
    }
}
