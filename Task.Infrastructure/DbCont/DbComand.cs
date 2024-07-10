using shared.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace Task.Infrastructure.DbCont
{
    public partial class DbComand : DbContext
    {
        public DbComand(DbContextOptions<DbComand> options): base(options)
        {
        }
        public virtual DbSet<RegistrationModel> Shopping { get; set; }
        public virtual DbSet<sellercredentials> SellerCred { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RegistrationModel>(entity => {
                entity.HasKey(k => k.Id);
            });
            modelBuilder.Entity<sellercredentials>(entity => {
                entity.HasKey(k => k.Id);
            });
            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
