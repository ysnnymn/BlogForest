using BlogForest.BusinessLayer.Abstract;
using BlogForest.DataAccessLayer.Abstract;
using BlogForest.EntityLayer.Concrete;

namespace BlogForest.BusinessLayer.Concrete;

public class AppUserManager:IAppUserService
    
{
    private readonly IAppUserDal _appUserDal;

    public AppUserManager(IAppUserDal appUserDal)
    {
        _appUserDal = appUserDal;
    }

    public void TInsert(AppUser entity)
    {
        throw new NotImplementedException();
    }

    public void TUpdate(AppUser entity)
    {
        throw new NotImplementedException();
    }

    public void TDelete(int id)
    {
        throw new NotImplementedException();
    }

    public AppUser TGetById(int id)
    {
        throw new NotImplementedException();
    }

    public List<AppUser> TGetListAll()
    {
        throw new NotImplementedException();
    }

    public AppUser TGetAppUserDetail(int id)
    {
        return _appUserDal.GetAppUserDetail(id);
    }
}