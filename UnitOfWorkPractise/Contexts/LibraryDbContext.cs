using Microsoft.EntityFrameworkCore;
using UnitOfWorkPractise.Configurations;
using UnitOfWorkPractise.Models;

namespace UnitOfWorkPractise.Contexts;

public class LibraryDbContext : DbContext
{
	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=LibraryDb1;Integrated Security=True");
		base.OnConfiguring(optionsBuilder);
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
        modelBuilder.ApplyConfiguration(new BookConfiguration());
        modelBuilder.ApplyConfiguration(new AuthorConfiguration());
        modelBuilder.ApplyConfiguration(new PressConfiguration());
        modelBuilder.ApplyConfiguration(new ThemeConfiguration());
        modelBuilder.ApplyConfiguration(new CategoryConfiguration());
        modelBuilder.ApplyConfiguration(new T_CardConfiguration());
        modelBuilder.ApplyConfiguration(new TeacherConfiguration());
        modelBuilder.ApplyConfiguration(new DepartmentConfiguration());
        modelBuilder.ApplyConfiguration(new S_CardConfiguration());
        modelBuilder.ApplyConfiguration(new StudentConfiguration());
        modelBuilder.ApplyConfiguration(new GroupConfiguration());
        modelBuilder.ApplyConfiguration(new FacultyConfiguration());
        modelBuilder.ApplyConfiguration(new LibConfiguration());

        base.OnModelCreating(modelBuilder);
    }

	public DbSet<Author>? Authors { get; set; }
	public DbSet<Book>? Books { get; set; }
	public DbSet<Category>? Categories { get; set; }
	public DbSet<Department>? Departments { get; set; }
	public DbSet<Faculty>? Faculties { get; set; }
	public DbSet<Group>? Groups { get; set; }
	public DbSet<Press>? Presses { get; set; }
	public DbSet<Theme>? Themes { get; set; }
	public DbSet<Lib>? Libs { get; set; }
	public DbSet<Student>? Students { get; set; }
	public DbSet<S_Card>? S_Cards { get; set; }
	public DbSet<Teacher>? Teachers { get; set; }
	public DbSet<T_Card>? T_Cards { get; set; }
}