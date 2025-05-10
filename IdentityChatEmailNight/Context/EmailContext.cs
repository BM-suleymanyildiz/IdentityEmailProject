using IdentityChatEmailNight.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityChatEmailNight.Context
{
    public class EmailContext : IdentityDbContext<AppUser>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-9TE47SL\\SQLEXPRESS; initial Catalog=EmailChatNightDb; integrated security=true;trust server certificate=true");//6 üstü sürümler için trust server certificate=true yazılmalı
        }
        public DbSet<Message> Messages { get; set; }
    }
}
