using AccountSellingMVC.Entities;
using Microsoft.EntityFrameworkCore;

namespace AccountSellingMVC.Data
{
    public static class DataSeeder
    {
        public static void SeedAccounts(ModelBuilder modelBuilder)
        {
            var accounts = new List<Account>
            {
                new Account 
                { 
                    Id = 1,
                    Username = "4qa7ma3m@c.cmkee.life",
                    Password = "qn30mqmm", 
                    RecoveryEmail = "4tfa2nff77@nguyenmail.top",
                    CreatedAt = DateTime.UtcNow
                },
                new Account 
                { 
                    Id = 2,
                    Username = "vn5c2n45@c.cmkee.life",
                    Password = "1cksbx7o",
                    RecoveryEmail = "e529nid7a@nguyenmail.top",
                    CreatedAt = DateTime.UtcNow
                },
                new Account 
                { 
                    Id = 3,
                    Username = "7tb4g6vl@c.cmkee.life",
                    Password = "nrkq5159",
                    RecoveryEmail = "umlddfrd@nguyenmail.top",
                    CreatedAt = DateTime.UtcNow
                },
                new Account 
                { 
                    Id = 4,
                    Username = "r0mbh3tz@c.cmkee.life",
                    Password = "14lbf3nc",
                    RecoveryEmail = "2776amyzv@nguyenmail.top",
                    CreatedAt = DateTime.UtcNow
                },
                new Account 
                { 
                    Id = 5,
                    Username = "v8vgfmpn@c.cmkee.life",
                    Password = "wzg3a8if",
                    RecoveryEmail = "fh5etxbn@nguyenmail.top",
                    CreatedAt = DateTime.UtcNow
                },
                new Account 
                { 
                    Id = 6,
                    Username = "z1hvkld2@c.cmkee.life",
                    Password = "ng2f509e",
                    RecoveryEmail = "998bekgyp@nguyenmail.top",
                    CreatedAt = DateTime.UtcNow
                },
                new Account 
                { 
                    Id = 7,
                    Username = "mq3rvwmy@c.cmkee.life",
                    Password = "vo0tn80s",
                    RecoveryEmail = "d4qs3klqh@nguyenmail.top",
                    CreatedAt = DateTime.UtcNow
                },
                new Account 
                { 
                    Id = 8,
                    Username = "7cq1xt3f@c.cmkee.life",
                    Password = "shb3ppr3",
                    RecoveryEmail = "xqq3fi17@nguyenmail.top",
                    CreatedAt = DateTime.UtcNow
                },
                new Account 
                { 
                    Id = 9,
                    Username = "i4ntmlot@c.cmkee.life",
                    Password = "qmlxskwg",
                    RecoveryEmail = "ovgfoxdui9@nguyenmail.top",
                    CreatedAt = DateTime.UtcNow
                },
                new Account 
                { 
                    Id = 10,
                    Username = "ozc5hvb9@c.cmkee.life",
                    Password = "bgzgy62l",
                    RecoveryEmail = "h9a5ovfbhn@nguyenmail.top",
                    CreatedAt = DateTime.UtcNow
                },
                new Account 
                { 
                    Id = 11,
                    Username = "3412tp9l@c.cmkee.life",
                    Password = "4iowfnuq",
                    RecoveryEmail = "3ksn5d6r@nguyenmail.top",
                    CreatedAt = DateTime.UtcNow
                }
            };

            modelBuilder.Entity<Account>().HasData(accounts);
        }
    }
}