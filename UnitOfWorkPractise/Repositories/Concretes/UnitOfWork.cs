using UnitOfWorkPractise.Contexts;
using UnitOfWorkPractise.Models;
using UnitOfWorkPractise.Repositories.Interfaces;

namespace UnitOfWorkPractise.Repositories.Concretes;

public class UnitOfWork
{
	public LibraryDbContext libraryDbContext;

	public UnitOfWork()
	{
		libraryDbContext = new();
	}

	public void Save()
	{
		libraryDbContext.SaveChanges();
	}

	// Async Version
	public async void SaveAsync()
	{
		await libraryDbContext.SaveChangesAsync();
	}


	public IRepository<Author> AuthorRepository => new Repository<Author>(libraryDbContext);
	public IRepository<Book> BookRepository => new Repository<Book>(libraryDbContext);
	public IRepository<Category> CategoryRepository => new Repository<Category>(libraryDbContext);
	public IRepository<Department> DepartmentRepository => new Repository<Department>(libraryDbContext);
	public IRepository<Faculty> FacultyRepository => new Repository<Faculty>(libraryDbContext);
	public IRepository<Group> GroupRepository => new Repository<Group>(libraryDbContext);
	public IRepository<Lib> LibRepository => new Repository<Lib>(libraryDbContext);
	public IRepository<Press> PressRepository => new Repository<Press>(libraryDbContext);
	public IRepository<S_Card> S_CardRepository => new Repository<S_Card>(libraryDbContext);
	public IRepository<Student> StudentRepository => new Repository<Student>(libraryDbContext);
	public IRepository<T_Card> T_CardRepository => new Repository<T_Card>(libraryDbContext);
	public IRepository<Teacher> TeacherRepository => new Repository<Teacher>(libraryDbContext);
	public IRepository<Theme> ThemeRepository => new Repository<Theme>(libraryDbContext);
}