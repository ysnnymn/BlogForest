using BlogForest.EntityLayer.Concrete;

namespace BlogForest.DataAccessLayer.Abstract;

public interface IAppUserDal:IGenericDal<AppUser>
{
    AppUser GetAppUserDetail(int id);
    
}