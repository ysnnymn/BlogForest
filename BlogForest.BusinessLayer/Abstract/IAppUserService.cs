using BlogForest.EntityLayer.Concrete;

namespace BlogForest.BusinessLayer.Abstract;

public interface IAppUserService:IGenericService<AppUser>
{
    public AppUser TGetAppUserDetail(int id);


}