using Microsoft.EntityFrameworkCore;


namespace Phc_Common_Api.DatabaseContext
{
    public class IBMD2Context: DbContext
    {

        public virtual DbSet<SUPPLIER_ORG> SUPPLIER_ORG { get; set; }
        public virtual DbSet<PARKER_DIV_XREF> PARKER_DIV_XREF { get; set; }
        public virtual DbSet<PARKER_LOC_XREF> PARKER_LOC_XREF { get; set; }
        public virtual DbSet<SUPP_PARKER_LOC> SUPP_PARKER_LOC { get; set; }
        public virtual DbSet<WEB_USER_SUPP_DIV> WEB_USER_SUPP_DIV { get; set; }

        public IBMD2Context(DbContextOptions<IBMD2Context> options)
              : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<WEB_USER_SUPP_DIV>().HasKey(k => new { k.WEB_ID  });
            builder.Entity<SUPPLIER_ORG>().HasKey(k => new { k.SUPP_ORG_ID });
            builder.Entity<PARKER_DIV_XREF>().HasKey(k => new { k.PARKER_DIV_ID });
            builder.Entity<PARKER_LOC_XREF>().HasKey(k => new { k.PARKER_DIV_ID, k.SECURITY_LOC_CD });
            builder.Entity<SUPP_PARKER_LOC>().HasKey(k => new { k.PARKER_DIV_ID, k.PARKER_LOC_CD, k.SUPP_ORG_ID });
        }
    }
}
