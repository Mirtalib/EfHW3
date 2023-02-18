namespace UnitOfWorkPractise.Repositories.Interfaces;

public interface IRepository<TEntity> where TEntity : class
{
    void Add(TEntity entity);
    void Update(TEntity entity);
    void Remove(TEntity entity);
    TEntity? GetById(int id);
}