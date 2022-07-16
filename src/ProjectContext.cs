using BibliotecaQuarkAcademy.src.app.Modelos;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace BibliotecaQuarkAcademy.src
{
    public class ProjectContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuider)
        {
            optionsBuider.UseSqlite(connectionString: "Filename=Biblioteca.db", sqliteOptionsAction: op =>
            {
                op.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
            });

            base.OnConfiguring(optionsBuider);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LibroModel>().ToTable("Libros");
            modelBuilder.Entity<LibroModel>(entity =>
            {
                entity.HasKey(ent => ent.Id);
            });
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<EjemplarModel>().ToTable("Ejemplares");
            modelBuilder.Entity<EjemplarModel>(entity =>
            {
                entity.HasKey(ent => ent.Id);
            });
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<SocioModel>().ToTable("Socios");
            modelBuilder.Entity<SocioModel>(entity =>
            {
                entity.HasKey(ent => ent.Id);
            });
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<LibroModel> Libros { get; set; }
        public DbSet<EjemplarModel> Ejemplares { get; set; }
        public DbSet<SocioModel> Socios { get; set; }
    }
}
