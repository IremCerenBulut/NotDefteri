using Microsoft.EntityFrameworkCore;

namespace NotDefteriApi.Data
{
    public class UygulamaDbContext:DbContext
    {
        public UygulamaDbContext(DbContextOptions<UygulamaDbContext>options):base(options)
        {

        }

        public DbSet<Not> Notlar=> Set<Not>();
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Not>().HasData(
                new Not() { Id=1,Baslik="Alınacaklar",Icerik="1.Bot\n 2.Kot"},
                new Not() { Id=2,Baslik="Görevler",Icerik="1.Ye\n 2.Dua et\n3.Sev"},
                new Not() { Id = 3, Baslik = "Gez & Gör", Icerik = "1.Muş\n 2.Van\n 3.Of" }
                );
        }
    }
}
