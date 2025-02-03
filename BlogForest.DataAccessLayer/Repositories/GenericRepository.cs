using BlogForest.DataAccessLayer.Abstract;
using BlogForest.DataAccessLayer.Context;


namespace BlogForest.DataAccessLayer.Repositories;

public class GenericRepository<T>:IGenericDal<T> where T:class
{
    private readonly BlogContext _context;

    public GenericRepository(BlogContext context)
    {
        _context = context;
    }


    public void Insert(T entity)
    {
        _context.Set<T>().Add(entity);
        _context.SaveChanges();
    }

    public void Update(T entity)
    {
       _context.Set<T>().Update(entity);
       _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var value=_context.Set<T>().Find(id);
        
        _context.Set<T>().Remove(value);
        _context.SaveChanges();
    }

    public T GetById(int id)
    {
        return _context.Set<T>().Find(id);
    }

    public List<T> GetListAll()
    {
        return _context.Set<T>().ToList();
    }
}