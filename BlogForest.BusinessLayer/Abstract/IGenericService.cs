namespace BlogForest.BusinessLayer.Abstract;

public interface IGenericService<T> where T : class
{
    void TInsert(T entity);
    void TDelete(int id);
    T TGetById(int id);
    List<T> TGetListAll();
}