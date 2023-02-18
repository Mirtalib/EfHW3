using Microsoft.EntityFrameworkCore;
using UnitOfWorkPractise.Contexts;
using UnitOfWorkPractise.Models;
using UnitOfWorkPractise.Repositories.Interfaces;

namespace UnitOfWorkPractise.Repositories.Concretes;

public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
{
	public LibraryDbContext libraryDbContext;
	public DbSet<TEntity> dbSet;

	public Repository(LibraryDbContext libraryDb)
	{
		libraryDbContext = libraryDb;
		dbSet = libraryDb.Set<TEntity>();
	}

	public void Add(TEntity entity)
		=> dbSet.Add(entity);

	public void Remove(TEntity entity)
		=> dbSet.Remove(entity);

	public void Update(TEntity entity)
		=> dbSet.Update(entity);
	
	public TEntity? GetById(int id)
		=> dbSet.Find(id); // for Primary Key
}