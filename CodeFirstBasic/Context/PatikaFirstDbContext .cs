using CodeFirstBasic.Entities;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstBasic.Data
{
    public class PatikaFirstDbContext: DbContext
    {
        public PatikaFirstDbContext(DbContextOptions options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ZEKERIYA\\SQLEXPRESS;Database=Library;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        public DbSet<Game> Games { get; set; }
        public DbSet<Movie> Movies { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Game>(game =>
            {
                game.ToTable("Games");
                game.HasKey(x => x.Id);
                game.Property(x => x.Rating).HasColumnType("decimal(3,2)");
            });
            modelBuilder.Entity<Movie>(movie =>
            {
                movie.ToTable("Movies");
                movie.HasKey(x => x.Id);
            });
        }
    }
}
