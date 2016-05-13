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

                context.CauHois.Add(new CauHoi { Ten = "KD_1", NoiDung = "Đỉnh núi cao nhất Việt Nam là gì ?", LinhVuc = "Địa Lý", DapAn = "Phan Xi Păng", ID_Goi=1 });
                context.CauHois.Add(new CauHoi { Ten = "KD_2", NoiDung = "Đỉnh núi cao nhất Thế giói là gì ?", LinhVuc = "Địa Lý", DapAn = "Everest", ID_Goi = 1 });
                context.CauHois.Add(new CauHoi { Ten = "KD_3", NoiDung = "Việt Nam có bao nhiêu tỉnh thành ?", LinhVuc = "Xã Hội", DapAn = "63", ID_Goi = 1 });
                context.CauHois.Add(new CauHoi { Ten = "KD_2", NoiDung = "Việt Nam có bao nhiêu dân tộc anh em ?", LinhVuc = "Xã Hội", DapAn = "54", ID_Goi = 1 });
                context.CauHois.Add(new CauHoi { Ten = "KD_2", NoiDung = "Việt Nam có bao nhiêu dân tộc anh em ?", LinhVuc = "Xã Hội", DapAn = "54", ID_Goi = 1 });

                context.SaveChanges();

                context.Users.Add(new User { Ten = "Admin", Username = "admin", Type = 0, Password = "admin" });
                context.Users.Add(new User { Ten = "Mc", Username = "mc", Type = 1, Password = "mc" });
                context.Users.Add(new User { Ten = "Thí sinh số 1", Username = "ts_1", Type = 2, Password = "ts_1" });
                context.Users.Add(new User { Ten = "Thí sinh số 2", Username = "ts_2", Type = 2, Password = "ts_2" });
                context.Users.Add(new User { Ten = "Thí sinh số 3", Username = "ts_3", Type = 2, Password = "ts_3" });
                context.Users.Add(new User { Ten = "Thí sinh số 4", Username = "ts_4", Type = 2, Password = "ts_4" });

                context.SaveChanges();
            }
        }
    }
}
